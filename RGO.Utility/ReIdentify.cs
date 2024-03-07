using FAnsi.Discovery;
using Microsoft.Data.SqlClient;
using RGO.DataAccess.Repository;
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
    private UnitOfWork _unitOfWork;

    public ReIdentify(RGO_Dataset dataset, RGO_ReIdentificationConfiguration reidentificationConfiguration, UnitOfWork unitOfWork) {
        _dataset = dataset;
        _config = reidentificationConfiguration;
        _unitOfWork = unitOfWork;
    }

    public void Execute()
    {

        //this only does sql atm, should add type
        var ConnectionString = $"Server={_config.Server};Database={_config.Database};Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        var records = _unitOfWork.RGO_Record.GetAll().Where( r => r.RGO_Dataset.Id == _dataset.Id ).Select(r => r.Id).ToList();
        var ids = _unitOfWork.RGO_Column.GetAll().Where(c => c.IsIdentifier ==1  && records.Contains(c.RGO_RecordId)).ToList();
        var sql = $"select {_config.DeIdentifiedColumn}, {_config.IdentityColumn} from {_config.Table} where {_config.DeIdentifiedColumn} in ({string.Join(",",ids)})";
        DiscoveredServer server = new DiscoveredServer(ConnectionString.ToString(), FAnsi.DatabaseType.MicrosoftSQLServer);
        using var conn = server.GetConnection();
        conn.Open();
        SqlCommand cmd = new SqlCommand(sql, (SqlConnection)conn);
        //todo fill a datatable or something
        DataTable t1 = new DataTable();
        using (SqlDataAdapter a = new SqlDataAdapter(cmd))
        {
            a.Fill(t1);
        }
        var x = 1 + 1;
    }
}
