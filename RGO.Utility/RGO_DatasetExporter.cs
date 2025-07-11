﻿using FAnsi.Discovery;
using FAnsi;
using Humanizer;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using RGO.DataAccess;
using RGO.DataAccess.Repository.IRepository;
using RGO.Models.Models;
using System.Data;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using Npgsql;

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
        var _config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
        var ConnectionString = System.Environment.GetEnvironmentVariable("ConnectionStrings__DefaultConnection") ?? _config.GetValue(typeof(object), "ConnectionStrings:DefaultConnection");
        var server = new DiscoveredServer(ConnectionString.ToString(), DatabaseType.PostgreSql);
        using var conn = server.GetConnection();
        conn.Open();
        var sql = "";
        using DataTable viewsDT = new();
        using DataTable resultsDT = new();
        StringBuilder sb = new StringBuilder();

        switch (DatabaseHelper.Instance.DatabaseType)
        {

            case DatabaseTypes.Postgres:
                sql = "select table_name from INFORMATION_SCHEMA.views";
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, (NpgsqlConnection)conn);
                adapter.Fill(viewsDT);
                var view = viewsDT.Rows.Cast<DataRow>().Where(dr => dr.ItemArray[0].ToString().StartsWith($"{_dataset.Dataset_Name.Replace(' ', '_').ToLower()}_{_dataset.Id}_")).FirstOrDefault();
                if (view is null)
                {
                    throw new Exception("Unable to find view");
                }
                sql = $"select * from {view.ItemArray[0]}";
                adapter = new NpgsqlDataAdapter(sql, (NpgsqlConnection)conn);
                adapter.Fill(resultsDT);
                break;
            case DatabaseTypes.MicrosoftSQL:
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(sql, (SqlConnection)conn);
                sqlAdapter.Fill(viewsDT);
                var sqlView = viewsDT.Rows.Cast<DataRow>().Where(dr => dr.ItemArray[0].ToString().StartsWith($"{_dataset.Dataset_Name.Replace(' ', '_').ToLower()}_{_dataset.Id}_")).FirstOrDefault();
                if (sqlView is null)
                {
                    throw new Exception("Unable to find view");
                }
                sql = $"select * from {sqlView.ItemArray[0]}";
                sqlAdapter = new SqlDataAdapter(sql, (SqlConnection)conn);
                sqlAdapter.Fill(resultsDT);
                break;
            default:
                throw new Exception("Unknown Database Type");
        }
      

        IEnumerable<string> columnNames = resultsDT.Columns.Cast<DataColumn>().
                                          Select(column => column.ColumnName);
        sb.AppendLine(string.Join(",", columnNames));

        foreach (DataRow row in resultsDT.Rows)
        {
            IEnumerable<string> fields = row.ItemArray.Select(field => field.ToString());
            sb.AppendLine(string.Join(",", fields));
        }
        return sb.ToString();
    }
}


//todo add group and also template dewcriptions to csv export


//DECLARE @cols AS NVARCHAR(MAX),
//    @query AS NVARCHAR(MAX),
//	@datasetId AS int

//set @datasetId=1

//select @cols = STUFF((SELECT ',' + QUOTENAME(Name)
//                    from[R - GO].[dbo].[RGO_Columns] as cols

//                    join[R - GO].[dbo].[RGO_Records] as records on records.Id = RGO_RecordId

//                    where records.RGO_DatasetId = @datasetId
//                    group by[RGO_RecordId], Name, cols.id
//                    having[RGO_RecordId] = (SELECT TOP 1 MIN([RGO_RecordId])FROM[R - GO].[dbo].[RGO_Columns])
//                    order by cols.id
//            FOR XML PATH(''), TYPE
//            ).value('.', 'NVARCHAR(MAX)')
//        ,1,1,'')




//set @query = N'SELECT ' + @cols + N' from 
//             (
//                select Column_Value, Name,[RGO_RecordId]
//                from [R - GO].[dbo].[RGO_Columns]
//join[R - GO].[dbo].[RGO_Records] as records on records.Id = RGO_RecordId
//where records.RGO_DatasetId='+ CAST(@datasetId as varchar)+ ' 
//GROUP BY[RGO_RecordId], Name, Column_Value
//            ) x
//            pivot
//            (
//                max(Column_Value)
//                for Name in (' + @cols + N')
//            ) p '
//exec sp_executesql @query;
