using Humanizer;
using RGO.DataAccess.Repository.IRepository;
using RGO.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace RGO.Utility;
//generates an exportable csv string  from a dataset
public class RGO_DatasetExporter
{
    private RGO_Dataset _dataset;
    private readonly IUnitOfWork _unitOfWork;
    public RGO_DatasetExporter(IUnitOfWork unitOfWork, RGO_Dataset dataset)
    {
        _unitOfWork = unitOfWork;
        _dataset = dataset;
    }

    public string GenerateExportableData()
    {
        var datasetTemplate = _unitOfWork.RGO_Dataset_Template.GetAll().Where(t => t.Id == _dataset.RGO_Dataset_TemplateId).First();
        var records = _unitOfWork.RGO_Record.GetAll().Where(r => r.RGO_DatasetId == _dataset.Id);
        var columns = _unitOfWork.RGO_Column.GetAll().Where(c => records.Select(s => s.Id).Contains(c.RGO_RecordId));
        var columnNames = columns.Select(c => c.Name).Distinct();

        var orderedRecords = new Dictionary<int, Dictionary<string, string>>();
        foreach (var column in columns)
        {
            orderedRecords.TryGetValue(column.RGO_RecordId, out var foundRecord);
            if (foundRecord is null)
            {
                foundRecord = new Dictionary<string, string>();
            }
            foundRecord.Add(column.Name, column.Column_Value);
            orderedRecords[column.RGO_RecordId] = foundRecord;
        }
        var columnStrings = string.Join(",", columns.Select(c => c.Name).Distinct());
        var recordStrings = new List<string>();
        foreach(var recordId in orderedRecords.Keys)
        {
            var record = orderedRecords[recordId];
            var newRecord = new List<string>();
            foreach(var column in columnNames) {
                //to do munge
                newRecord.Add(record[column]);
            }
            recordStrings.Add(string.Join(",", newRecord));
        }
        var returnString = columnStrings;
        foreach(var r in recordStrings)
        {
            returnString = returnString + Environment.NewLine + r.ToString();
        }
        return returnString;
    }
}


//todo add group and also template dewcriptions to csv export


////attemp1 1 at view
//DECLARE @cols AS NVARCHAR(MAX),
//    @query AS NVARCHAR(MAX)

//select @cols = STUFF((SELECT ',' + QUOTENAME(Name)
//                    from[R - GO].[dbo].[RGO_Columns]
//                    group by[RGO_RecordId], Name, id
//                    having[RGO_RecordId] = (SELECT TOP 1 MIN([RGO_RecordId])FROM[R - GO].[dbo].[RGO_Columns])
//                    order by id
//            FOR XML PATH(''), TYPE
//            ).value('.', 'NVARCHAR(MAX)')
//        ,1,1,'')


        

//set @query = N'SELECT ' + @cols + N' from 
//             (
//                select Column_Value, Name,[RGO_RecordId]
//                from [R - GO].[dbo].[RGO_Columns]
//GROUP BY[RGO_RecordId], Name, Column_Value
//            ) x
//            pivot
//            (
//                max(Column_Value)
//                for Name in (' + @cols + N')
//            ) p '
//exec sp_executesql @query;
