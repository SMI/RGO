using FAnsi.Discovery;
using FAnsi.Implementation;
using FAnsi.Implementations.MicrosoftSQL;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.VisualBasic.FileIO;
using RGO.DataAccess.Data;
using RGO.DataAccess.Repository;
using RGO.DataAccess.Repository.IRepository;
using RGO.Models.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RGO
{
    public class CSV_Uploader
    {
        private string _filePath;
        private int _datasetTemplateId;
        private int _datasetId;
        private int _recordId;
        private ApplicationDbContext _context;
        private IUnitOfWork _unitOfWork;
        private RGO_Dataset_Template _datasetTemplate;



        public void ExecuteUpload()
        {
            //string inputFile = @"C:\Temp\RGO_2.csv";
            //var uploader = new CSV_Uploader("C:\RGX_2.csv");

            if (PreCheck().Equals(true))
            {

                createDatasetRecord();

                //RGO_RecordRepository recrepo = new RGO_RecordRepository(_context);
                //RGO_ColumnRepository colrepo = new RGO_ColumnRepository(_context);
                //RGO_Record_PersonRepository rprepo = new RGO_Record_PersonRepository(_context);

                int recordIndex = 0;
                List<string> columnHeaders = new List<string>();

                int columnIndex = 0;
                List<string> columnValues = new List<string>();


                foreach (var line in File.ReadLines(_filePath))
                {
                    if (recordIndex == 0)
                    {
                        //Grab the column headers
                        line.Split(",").ToList().ForEach(columnHeaders.Add);



                    }
                    else
                    {
                        // Create a RGO_Record record for each non-header row

                        RGO_Record recrec = new RGO_Record();

                        recrec.RGO_DatasetId = _datasetId;
                        recrec.Created_By = "RGO_Upload";
                        recrec.Record_Status = "Uploading";
                        _unitOfWork.RGO_Record.Add(recrec);

                        _unitOfWork.Save();
                        _recordId = recrec.Id;

                        // Grab the column values for this record
                        line.Split(",").ToList().ForEach(columnValues.Add);



                        //Loop through the columns in column headers
                        foreach (var header in columnHeaders)
                        {

                            //var _colRepository = new RGO_Column_TemplateRepository(_context);
                            var _columnTemplate = _unitOfWork.RGO_Column_Template.GetAll().Where(r => r.RGO_Dataset_TemplateId.Equals(_datasetTemplateId)).FirstOrDefault();

                            if (!header.StartsWith("Ground_Truther"))
                            {
                                // Create a new RGO_Column Record
                                RGO_Column colrec = new RGO_Column();

                                colrec.RGO_RecordId = recrec.Id;
                                colrec.Name = header;
                                colrec.PK_Column_Order = _columnTemplate.PK_Column_Order;
                                colrec.Type = _columnTemplate.Type;
                                colrec.Potentially_Disclosive = _columnTemplate.Potentially_Disclosive;
                                colrec.Column_Value = columnValues[columnIndex];
                                colrec.Column_Status = "Uploading";
                                colrec.Created_By = "RGO_Upload";
                                //colrec.Created_Date = DateTime.Now;

                                _unitOfWork.RGO_Column.Add(colrec);
                                _unitOfWork.Save();

                            }
                            else
                            {
                                //Find the id of the person record with this name

                                var _person = _unitOfWork.Person.GetAll().Where(pr => pr.Name.Equals(columnValues[columnIndex])).FirstOrDefault();

                                // Create a new RGO_Person_Record Record
                                RGO_Record_Person rprec = new RGO_Record_Person();


                                rprec.RGO_RecordId = recrec.Id;
                                rprec.PersonId = _person.Id;
                                rprec.Person_Record_Role = "Ground Truther";
                                rprec.Created_By = "RGO_Upload";
                                //rprec.Created_Date = DateTime.Now;

                                _unitOfWork.RGO_Record_Person.Add(rprec);
                                _unitOfWork.Save();
                            }
                            columnIndex++;

                        }


                    }

                    recordIndex++;
                }

                CreateView();

            }
        }

        public CSV_Uploader(string filePath,IUnitOfWork unitOfWork)
        {
            _filePath = filePath;
            _unitOfWork = unitOfWork;

        }

        public bool PreCheck()
        {
            if (!File.Exists(_filePath)) return false;
            var _fileInfo = new FileInfo(_filePath);
            var _fileName = _fileInfo.FullName;
            var _fileNameNoExt = Path.GetFileNameWithoutExtension(_fileName);
            if (!_fileNameNoExt.StartsWith("RGO_")) return false;
            var datasetTemplateId = _fileNameNoExt.Substring(4);

            _datasetTemplateId = int.Parse(datasetTemplateId);
            _datasetTemplate = _unitOfWork.RGO_Dataset_Template.GetAll().Where(r => r.Id.Equals(_datasetTemplateId)).FirstOrDefault();

            if (_datasetTemplate == null) { return false; }

            return true;
        }

        public bool createDatasetRecord()
        {
            RGO_Dataset dsrec = new RGO_Dataset();

            dsrec.RGO_Dataset_TemplateId = _datasetTemplateId;
            dsrec.Dataset_Name = _datasetTemplate.Name;
            dsrec.Dataset_Status = "Uploading";
            dsrec.Created_By = "RGO_Upload";

            _unitOfWork.RGO_Dataset.Add(dsrec);
            _unitOfWork.Save();

            _datasetId = dsrec.Id; //does this exist? 

            return true;
        }

        private static readonly Regex sWhitespace = new Regex(@"\s+");
        public static string ReplaceWhitespace(string input, string replacement)
        {
            return sWhitespace.Replace(input, replacement);
        }


        private void CreateView()
        {
            //todo this doesn't work in postgres
            var datasetId = _datasetId;
            var dataset = _unitOfWork.RGO_Dataset.GetAll().Where(ds => ds.Id == datasetId).FirstOrDefault();
            var datasetTemplate = _unitOfWork.RGO_Dataset_Template.GetAll().Where(t => t.Id == dataset.RGO_Dataset_TemplateId).FirstOrDefault();
            var columns = string.Join(',', _unitOfWork.RGO_Column_Template.GetAll().Where(c => c.RGO_Dataset_TemplateId == datasetTemplate.Id).Select(c => c.Name).ToList());
            var viewName = $"{_datasetTemplate.Name}_{DateTimeOffset.UtcNow.ToUnixTimeSeconds()}";
            viewName = ReplaceWhitespace(viewName, "_");
            var sql = @$"
                create view {viewName} as
with cols as (
select STUFF((SELECT ',' + QUOTENAME(Name)
                    from[R-GO].[dbo].[RGO_Columns] as cols

                    join[R-GO].[dbo].[RGO_Records] as records on records.Id = RGO_RecordId

                    where records.RGO_DatasetId = {datasetId}
                    group by[RGO_RecordId], Name, cols.id
                    having[RGO_RecordId] = (SELECT TOP 1 MIN([RGO_RecordId])FROM[R-GO].[dbo].[RGO_Columns])
                    order by cols.id
            FOR XML PATH(''), TYPE
            ).value('.', 'NVARCHAR(MAX)')
        ,1,1,'') as linkedcols
)
select {columns} from
             (
                select Column_Value, Name,[RGO_RecordId]
                from [R-GO].[dbo].[RGO_Columns]
join[R-GO].[dbo].[RGO_Records] as records on records.Id = RGO_RecordId
where records.RGO_DatasetId= {datasetId}
GROUP BY[RGO_RecordId], Name, Column_Value
            ) x
            pivot
          (
                max(Column_Value)
                for Name in ( {columns})
            ) p
            ";
            //tell JRF to fix this
            
            
            var ConnectionString = "Server=(localdb)\\MSSQLLocalDB;Database=R-GO;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            DiscoveredServer server = new DiscoveredServer(ConnectionString, FAnsi.DatabaseType.MicrosoftSQLServer);
            using var conn = server.GetConnection();
            conn.Open();
            var cmd = server.GetCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

    }
}
