using System.Reflection;
using System.Text.RegularExpressions;
using NPOI.XSSF.UserModel;
using RGO.DataAccess.Repository.IRepository;
using RGO.Models.Models;

namespace RGO.Utility;

public class CSVGenerator
{
    private readonly RGO_Dataset_Template _datasetTemplate;
    private readonly IUnitOfWork _unitOfWork;

    public CSVGenerator(RGO_Dataset_Template datasetTemplate, IUnitOfWork unitOfWork)
    {
        _datasetTemplate = datasetTemplate;
        _unitOfWork = unitOfWork;
    }

    private static readonly Regex sWhitespace = new(@"\s+");

    private static string ReplaceWhitespace(string input, string replacement)
    {
        return sWhitespace.Replace(input, replacement);
    }

    public string CreateCSV()
    {
        using var workbook = new XSSFWorkbook();

        var sheet = workbook.CreateSheet("Researcher Generated Outputs");
        var rgoutput = _unitOfWork.RGOutput.FirstOrDefault(u => u.Id == _datasetTemplate.RGOutput_Id);
        var group_id = rgoutput.Originating_GroupId;
        var group = _unitOfWork.Group.FirstOrDefault(u => u.Id == group_id);
        var ref_no = group.Reference_number ?? "No-reference";
        var columns = _unitOfWork.RGO_Column_Template.GetAll()
            .Where(c => c.RGO_Dataset_TemplateId == _datasetTemplate.Id).ToList();
        var people = _unitOfWork.Person.GetAll().Select(p => p.Name).ToArray();
        var row = sheet.CreateRow(0);
        var cellIndex = 0;

        foreach (var column in columns) row.CreateCell(cellIndex++).SetCellValue(column.Name);
        //if (column.Name.Contains("Ground_Truther"))
        //if (column.Name.StartsWith("Ground_Truther"))
        //    {
        //    //populate a dropdown list of known people
        //    IDataValidationHelper dataValidationHelper = new XSSFDataValidationHelper((XSSFSheet)sheet);
        //    CellRangeAddressList cellRangeAddressList = new CellRangeAddressList(1, 10, cellIndex - 1, cellIndex - 1);
        //    IDataValidationConstraint dataValidationConstraint = dataValidationHelper.CreateExplicitListConstraint(people);
        //    IDataValidation dataValidation = dataValidationHelper.CreateValidation(dataValidationConstraint, cellRangeAddressList);
        //    sheet.AddValidationData(dataValidation);
        //}
        var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!;
        //string xlsxPath = Path.Combine(path, $"RGO_{ReplaceWhitespace(_datasetTemplate.Name, "_")}_{_datasetTemplate.Id}.xlsx");
        var xlsxPath = Path.Combine(path,
            $"RGO_{ReplaceWhitespace(ref_no.Trim(), "_")}_{ReplaceWhitespace(rgoutput.Name.Trim(), "_")}_{_datasetTemplate.Id}.xlsx");


        using var fileStream = new FileStream(xlsxPath, FileMode.Create, FileAccess.Write);
        workbook.Write(fileStream);

        return xlsxPath;
    }
}