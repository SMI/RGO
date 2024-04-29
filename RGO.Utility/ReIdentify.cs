using FAnsi.Discovery;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using RGO.DataAccess.Repository;
using RGO.DataAccess.Repository.IRepository;
using RGO.Models.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace RGO.Utility;

public class ReIdentify
{
    private RGO_Dataset _dataset;
    private RGO_ReIdentificationConfiguration _config;
    private IUnitOfWork _unitOfWork;
    private IConfigurationRoot _configRoot;

    public ReIdentify(RGO_Dataset dataset, RGO_ReIdentificationConfiguration reIdentificationConfiguration, IUnitOfWork unitOfWork)
    {
        _dataset = dataset;
        _config = reIdentificationConfiguration;
        _unitOfWork = unitOfWork;
        _configRoot = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
    }

    public void Execute()
    {

        //this only does sql atm, should add type
        var ConnectionString = $"Server={_config.Server};Database={_config.Database};Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        var records = _unitOfWork.RGO_Record.GetAll().Where(r => r.RGO_Dataset.Id == _dataset.Id).Select(r => r.Id).ToList();
        var ids = _unitOfWork.RGO_Column.GetAll().Where(c => c.IsIdentifier == 1 && records.Contains(c.RGO_RecordId)).Select(c => c.Column_Value).ToList();
        var sql = $"select [{_config.DeIdentifiedColumn}], [{_config.IdentityColumn}] from {_config.Table} where {_config.DeIdentifiedColumn} in ({string.Join(",", ids)})";
        DiscoveredServer server;
        if (_configRoot.GetValue(typeof(object), "DatabaseType").ToString() == "Postgres")
        {
            server = new DiscoveredServer(ConnectionString.ToString(), FAnsi.DatabaseType.PostgreSql);
        }
        else
        {
            server = new DiscoveredServer(ConnectionString.ToString(), FAnsi.DatabaseType.MicrosoftSQLServer);
        }
        using var conn = server.GetConnection();
        conn.Open();
        SqlCommand cmd = new SqlCommand(sql, (SqlConnection)conn);
        DataTable t1 = new DataTable();
        using (SqlDataAdapter a = new SqlDataAdapter(cmd))
        {
            try
            {
                a.Fill(t1);
            }
            catch (Exception) { }
        }
        foreach (DataRow row in t1.Rows)
        {
            var mathces = _unitOfWork.RGO_Column.GetAll().Where(c => c.IsIdentifier == 1 && records.Contains(c.RGO_RecordId) && c.Column_Value == row[0].ToString().Trim()).ToList();
            foreach (var match in mathces)
            {
                match.Column_Value = row[1].ToString();
                _unitOfWork.RGO_Column.Update(match);
                _unitOfWork.Save();
            }

        }
    }
}
