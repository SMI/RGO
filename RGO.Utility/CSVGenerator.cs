using RGO.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPOI.XSSF.UserModel;
using System.Reflection;
using RGO.DataAccess.Repository;
using RGO.DataAccess.Repository.IRepository;
using System.Text.RegularExpressions;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.SS.Formula.Functions;
namespace RGO.Utility
{
    public class CSVGenerator
    {

        private readonly RGO_Dataset_Template _datasetTemplate;
        private readonly IUnitOfWork _unitOfWork;

        public CSVGenerator(RGO_Dataset_Template datasetTemplate, IUnitOfWork unitOfWork)
        {
            _datasetTemplate = datasetTemplate;
            _unitOfWork = unitOfWork;
        }

        private static readonly Regex sWhitespace = new Regex(@"\s+");
        private static string ReplaceWhitespace(string input, string replacement)
        {
            return sWhitespace.Replace(input, replacement);
        }

        public string CreateCSV()
        {
            using var workbook = new XSSFWorkbook();

            var sheet = workbook.CreateSheet("Researcher Generated Outputs");
            var columns = _unitOfWork.RGO_Column_Template.GetAll().Where(c => c.RGO_Dataset_TemplateId == _datasetTemplate.Id).ToList();
            var people = _unitOfWork.Person.GetAll().Select(p => p.Name).ToArray();
            var row = sheet.CreateRow(0);
            var cellIndex = 0;

            foreach (var column in columns)
            {
                row.CreateCell(cellIndex++).SetCellValue(column.Name);
                if (column.Name.Contains("Ground_Truther"))
                {
                    //populate a dropdown list of known people
                    IDataValidationHelper dataValidationHelper = new XSSFDataValidationHelper((XSSFSheet)sheet);
                    CellRangeAddressList cellRangeAddressList = new CellRangeAddressList(1, 10, cellIndex - 1, cellIndex - 1);
                    IDataValidationConstraint dataValidationConstraint = dataValidationHelper.CreateExplicitListConstraint(people);
                    IDataValidation dataValidation = dataValidationHelper.CreateValidation(dataValidationConstraint, cellRangeAddressList);
                    sheet.AddValidationData(dataValidation);

                }

            }
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!;
            string xlsxPath = Path.Combine(path, $"RGO_{ReplaceWhitespace(_datasetTemplate.Name, "_")}_{_datasetTemplate.Id}.xlsx");

            using var fileStream = new FileStream(xlsxPath, FileMode.Create, FileAccess.Write);
            workbook.Write(fileStream);

            return xlsxPath;

        }
    }
}
