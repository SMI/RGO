using FAnsi.Discovery.TypeTranslation;
using FAnsi.Implementations.MicrosoftSQL;
using FAnsi.Implementations.PostgreSql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGO.DataAccess;

public class DatabaseHelper
{
    private static readonly Lazy<DatabaseHelper> lazy =
      new Lazy<DatabaseHelper>(() => new DatabaseHelper());

    public static DatabaseHelper Instance { get { return lazy.Value; } }


    public DatabaseTypes? DatabaseType { get; private set; }

    private DatabaseHelper()
    {
    }

    public void SetDatabaseType(DatabaseTypes database)
    {
        if (DatabaseType != null)
            //throw new Exception("Database type has already been instantiated.");
            return;
        DatabaseType = database;
    }

    public TypeTranslater GetTypeTranslator()
    {
        switch(DatabaseType)
        {
            case DatabaseTypes.MicrosoftSQL:
                return MicrosoftSQLTypeTranslater.Instance;
            case DatabaseTypes.Postgres:
                return PostgreSqlTypeTranslater.Instance;
            default:
                throw new Exception("Unable to fetch database type translator. Database type not set.");
        }
    }
}
