using System.Text.RegularExpressions;
using FAnsi;
using FAnsi.Discovery;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using RGO.DataAccess.Data;
using RGO.DataAccess.Repository.IRepository;
using RGO.Models.Models;

namespace RGO;

public class CSV_Uploader
{
    private string _filePath;
    private int _datasetTemplateId;
    private int _datasetId;
    private int _recordId;
    private ApplicationDbContext _context;
    private readonly IUnitOfWork _unitOfWork;
    private RGO_Dataset_Template _datasetTemplate;
    private readonly IConfigurationRoot _config;
    private bool isXls;


    //public void ExecuteUpload()
    public bool ExecuteUpload()
    {
        if (PreCheck().Equals(true))
        {
            createDatasetRecord();

            var recordIndex = 0;
            var columnHeaders = new List<string>();

            var columnIndex = 0;
            //<string> columnValues = new List<string>();

            if (_filePath.EndsWith(".xlsx"))
            {
                isXls = true;
                //convert to csv
                var csvSeparator = ",";
                var newFilePath = _filePath.Replace(".xlsx", ".csv");
                var sw = new StreamWriter(newFilePath, false);
                using (var file = new FileStream(_filePath, FileMode.Open, FileAccess.Read))
                {
                    var strExt = Path.GetExtension(_filePath);

                    IWorkbook wb;

                    #region Check extension to define the Workbook

                    if (strExt.Equals(".xls"))
                        wb = new HSSFWorkbook(file);
                    else
                        wb = new XSSFWorkbook(file);

                    #endregion

                    var sheet = wb.GetSheetAt(0); //Start reading at index 0

                    //wb.MissingCellPolicy = MissingCellPolicy.RETURN_NULL_AND_BLANK;

                    for (var i = 0; i <= sheet.LastRowNum; i++) //Row
                    {
                        var row = sheet.GetRow(i);

                        for (var j = 0; j < row.LastCellNum; j++) //Column
                        {
                            var cell = row.GetCell(j);


                            object cellValue = null;

                            if (cell == null)
                            {
                                //It's an empty cell
                                sw.Write(csvSeparator); //Add the CSV separator
                                continue;
                            }

                            #region Check cell type in order to define its value type

                            switch (cell.CellType)
                            {
                                case CellType.Blank:
                                case CellType.Error:
                                    cellValue = null;
                                    break;
                                case CellType.Boolean:
                                    cellValue = cell.BooleanCellValue;
                                    break;
                                case CellType.Numeric:
                                    cellValue = cell.NumericCellValue;
                                    break;
                                case CellType.String:
                                    cellValue = cell.StringCellValue;
                                    break;
                                default:
                                    cellValue = cell.StringCellValue;
                                    break;
                            }

                            #endregion

                            sw.Write(cellValue.ToString()); //Write the cell value
                            sw.Write(csvSeparator); //Add the CSV separator
                        }

                        sw.Write(Environment.NewLine); //Add new line
                    }

                    sw.Flush();
                    sw.Close();
                    _filePath = newFilePath;
                }
            }


            foreach (var line in File.ReadLines(_filePath))
            {
                if (line.Length == 0) break;
                string line2;
                if (recordIndex == 0)
                {
                    //Grab the column headers
                    line2 = line.Substring(0, line.Length - 1);
                    line2.Split(",").ToList().ForEach(columnHeaders.Add);
                }
                else
                {
                    // Create a RGO_Record record for each non-header row

                    var recrec = new RGO_Record();

                    recrec.RGO_DatasetId = _datasetId;
                    recrec.Created_By = "RGO_Upload";
                    //recrec.Record_Status = "Uploading";
                    _unitOfWork.RGO_Record.Add(recrec);

                    _unitOfWork.Save();
                    _recordId = recrec.Id;

                    // Grab the column values for this record
                    line2 = line.Substring(0, line.Length - 1);
                    var columnValues = line2.Split(",");

                    //Loop through the columns in column headers
                    foreach (var header in columnHeaders)
                    {
                        // find the column template for this dataset_template_id and column_name
                        //var _columnTemplate = _unitOfWork.RGO_Column_Template.GetAll().Where(r => r.RGO_Dataset_TemplateId.Equals(_datasetTemplateId)).FirstOrDefault();
                        var _columnTemplate = _unitOfWork.RGO_Column_Template.GetAll()
                            .Where(r => r.RGO_Dataset_TemplateId.Equals(_datasetTemplateId) && r.Name == header)
                            .FirstOrDefault();

                        if (_columnTemplate != null)
                        {
                            if (!header.StartsWith("Ground_Truther"))
                            {
                                // Create a new RGO_Column Record
                                var colrec = new RGO_Column();

                                colrec.RGO_RecordId = recrec.Id;
                                colrec.RGO_Column_TemplateId = _columnTemplate.Id;
                                colrec.Name = header;
                                colrec.PK_Column_Order = _columnTemplate.PK_Column_Order;
                                colrec.Type = _columnTemplate.Type;
                                colrec.Potentially_Disclosive = _columnTemplate.Potentially_Disclosive;
                                colrec.Column_Value = columnIndex >= columnValues.Length
                                    ? null
                                    : columnValues[columnIndex];
                                if (colrec.Column_Value == "") colrec.Column_Value = null;
                                colrec.Created_By = "RGO_Upload";
                                //colrec.Created_Date = DateTime.Now;

                                _unitOfWork.RGO_Column.Add(colrec);
                                _unitOfWork.Save();
                            }
                            else
                            {
                                //Find the id of the person record with this name

                                var _person = _unitOfWork.Person.GetAll()
                                    .Where(pr => pr.Name.Equals(columnValues[columnIndex])).FirstOrDefault();

                                // Create a new RGO_Person_Record Record
                                var rprec = new RGO_Record_Person();


                                rprec.RGO_RecordId = recrec.Id;
                                rprec.RGO_Column_TemplateId = _columnTemplate.Id;
                                rprec.PersonId = _person.Id;
                                rprec.Person_Record_Role = "Ground Truther";
                                rprec.Created_By = "RGO_Upload";

                                _unitOfWork.RGO_Record_Person.Add(rprec);
                                _unitOfWork.Save();
                            }
                        }
                        else //It's likely that the headers don't match
                        {
                            return false;
                        }

                        columnIndex++;
                    }

                    columnIndex = 0;
                }

                recordIndex++;
            }

            if (_config.GetValue(typeof(object), "DatabaseType").ToString() == "Postgres")
                CreatePostgresView();
            else
                CreateView();
        }
        else
        {
            return false;
        }

        setUploadedStatuses();
        return true;
    }


    public CSV_Uploader(string filePath, IUnitOfWork unitOfWork)
    {
        _filePath = filePath;
        _unitOfWork = unitOfWork;
        _config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
    }

    public bool PreCheck()
    {
        // Check that the file exists
        if (!File.Exists(_filePath)) return false;
        var _fileInfo = new FileInfo(_filePath);
        var _fileName = _fileInfo.FullName;
        var _fileNameNoExt = Path.GetFileNameWithoutExtension(_fileName);

        // CHeck that the filename starts with RGO_
        if (!_fileNameNoExt.StartsWith("RGO_")) return false;
        var datasetTemplateId = _fileNameNoExt.Split("_").Reverse().First();

        _datasetTemplateId = int.Parse(datasetTemplateId);
        _datasetTemplate = _unitOfWork.RGO_Dataset_Template.GetAll().Where(r => r.Id.Equals(_datasetTemplateId))
            .FirstOrDefault();

        //Check that the filename ends with a valid datasetTemplateId
        if (_datasetTemplate == null) return false;

        return true;
    }

    public bool createDatasetRecord()
    {
        var dsrec = new RGO_Dataset();

        dsrec.RGO_Dataset_TemplateId = _datasetTemplateId;
        //dsrec.Dataset_Name = _datasetTemplate.Name;
        dsrec.Dataset_Name = "Describe this particular dataset";
        dsrec.Dataset_Status = "Uploading";
        dsrec.Created_By = "RGO_Upload";
        dsrec.Release_Status_Id = _datasetTemplate.Release_Status_Id;

        _unitOfWork.RGO_Dataset.Add(dsrec);
        _unitOfWork.Save();

        _datasetId = dsrec.Id;

        return true;
    }


    public bool setUploadedStatuses()
    {
        var datasetId = _datasetId;
        var dataset = _unitOfWork.RGO_Dataset.GetAll().Where(ds => ds.Id == datasetId).FirstOrDefault();
        dataset.Dataset_Status = "Upload Complete";
        _unitOfWork.RGO_Dataset.Update(dataset);
        _unitOfWork.Save();

        return true;
    }

    private static readonly Regex sWhitespace = new(@"\s+");

    public static string ReplaceWhitespace(string input, string replacement)
    {
        return sWhitespace.Replace(input, replacement);
    }


    private void CreatePostgresView()
    {
        //todo ground truthers aren't working
        var datasetId = _datasetId;
        var dataset = _unitOfWork.RGO_Dataset.GetAll().Where(ds => ds.Id == datasetId).FirstOrDefault();
        var datasetTemplate = _unitOfWork.RGO_Dataset_Template.GetAll()
            .Where(t => t.Id == dataset.RGO_Dataset_TemplateId).FirstOrDefault();
        var columns = _unitOfWork.RGO_Column_Template.GetAll()
            .Where(c => c.RGO_Dataset_TemplateId == datasetTemplate.Id).Select(c => c.Name).ToList();
        var viewName = $"{_datasetTemplate.Name}_{DateTimeOffset.UtcNow.ToUnixTimeSeconds()}";
        viewName = ReplaceWhitespace(viewName, "_");
        var columnStrings = new List<string>();
        foreach (var column in columns)
        {
            var str =
                $"  MIN(CASE WHEN LOWER(rc.\"Name\") = LOWER('{column}') THEN rc.\"Column_Value\" END) AS {column}";
            columnStrings.Add(str);
        }

        var sql = $@"
            create view {viewName} as
            with rc as (
                select ""Column_Value"", ""Name"", ""RGO_RecordId""
                from ""RGO_Columns"" as rc
                join ""RGO_Records"" as records on records.""Id"" = ""RGO_RecordId"" 
	            where records.""RGO_DatasetId""= {_datasetId}

	            union all
				(select p.""Name"", concat('Ground_Truther_',(1+ rec.""Id"" - startValue)), rec.""RGO_RecordId""
from ""RGO_Record_People"" as rec
join ""People"" as p on p.""Id"" = rec.""PersonId""
join(
select min(rec.""Id"") as startValue, rec.""RGO_RecordId""
from ""RGO_Record_People"" as rec
join ""People"" as p on p.""Id"" = rec.""PersonId""
join ""RGO_Records"" as r on r.""Id"" = rec.""RGO_RecordId""
where R.""RGO_DatasetId""= {_datasetId}
group by rec.""RGO_RecordId"") as mid on mid.""RGO_RecordId"" = rec.""RGO_RecordId"")

                order by 3
            )
            select 
            ""RGO_RecordId"",
            {(columnStrings.Count > 0 ? string.Join(',', columnStrings) : "")}
            from rc
            group by ""RGO_RecordId""
            ";
        var ConnectionString = _config.GetValue(typeof(object), "ConnectionStrings:DefaultConnection");
        var server = new DiscoveredServer(ConnectionString.ToString(), DatabaseType.PostgreSql);
        using var conn = server.GetConnection();
        conn.Open();
        var cmd = server.GetCommand(sql, conn);
        cmd.ExecuteNonQuery();
    }


    private void CreateView()
    {
        //todo ground truthers aren't working
        var datasetId = _datasetId;
        var dataset = _unitOfWork.RGO_Dataset.GetAll().Where(ds => ds.Id == datasetId).FirstOrDefault();
        var datasetTemplate = _unitOfWork.RGO_Dataset_Template.GetAll()
            .Where(t => t.Id == dataset.RGO_Dataset_TemplateId).FirstOrDefault();
        var columns = string.Join(',',
            _unitOfWork.RGO_Column_Template.GetAll().Where(c => c.RGO_Dataset_TemplateId == datasetTemplate.Id)
                .Select(c => c.Name).ToList());
        var viewName = $"{_datasetTemplate.Name}_{DateTimeOffset.UtcNow.ToUnixTimeSeconds()}";
        viewName = ReplaceWhitespace(viewName, "_");
        var sql = @$"
                create view {viewName} as
select {columns} from
             (
                select Column_Value, Name,[RGO_RecordId]
                from [R-GO].[dbo].[RGO_Columns]
join[R-GO].[dbo].[RGO_Records] as records on records.Id = RGO_RecordId
where records.RGO_DatasetId= {datasetId}
GROUP BY[RGO_RecordId], Name, Column_Value

union all
select p.Name, 'Ground_Truther_'+ cast(1+ rec.Id - startValue as varchar(100)), rec.RGO_RecordId
from [R-GO].[dbo].[RGO_Record_People] as rec
join [R-GO].[dbo].[People] as p on p.Id = rec.PersonId
join(
select min(rec.Id) as startValue, rec.RGO_RecordId
from [R-GO].[dbo].[RGO_Record_People] as rec
join [R-GO].[dbo].[People] as p on p.Id = rec.PersonId
join [R-GO].[dbo].RGO_Records as r on r.Id = rec.RGO_RecordId
where r.RGO_DataSetId = {datasetId}
group by rec.RGO_RecordId) as mid on mid.RGO_RecordId = rec.RGO_RecordId

            ) x
            pivot
          (
                max(Column_Value)
                for Name in ( {columns})
            ) p
            ";
        var ConnectionString = _config.GetValue(typeof(object), "ConnectionStrings:DefaultConnection");
        var server = new DiscoveredServer(ConnectionString.ToString(), DatabaseType.MicrosoftSQLServer);
        using var conn = server.GetConnection();
        conn.Open();
        var cmd = server.GetCommand(sql, conn);
        cmd.ExecuteNonQuery();
    }
}