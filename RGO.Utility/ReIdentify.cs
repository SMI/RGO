using FAnsi.Discovery;
using RGO.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace RGO.Utility;

public class ReIdentify
{
    private RGO_Dataset _dataset;
    private RGO_ReIdentificationConfiguration _config;

    public ReIdentify(RGO_Dataset dataset, RGO_ReIdentificationConfiguration reidentificationConfiguration) {
        _dataset = dataset;
        _config = reidentificationConfiguration;
    }

    public void Execute()
    {

        //this only does sql atm, should add type
        var ConnectionString = $"Server={_config.Server};Database={_config.Database};Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        var sql = $"select {_config.DeIdentifiedColumn}, {_config.IdentityColumn} from {_config.Table} where";//only match 
        DiscoveredServer server = new DiscoveredServer(ConnectionString.ToString(), FAnsi.DatabaseType.MicrosoftSQLServer);
        using var conn = server.GetConnection();
        conn.Open();
        var cmd = server.GetCommand(sql, conn);
        cmd.ExecuteNonQuery();
    }
}
