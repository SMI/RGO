using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGO.Utility;

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
        if(DatabaseType != null)
            throw new Exception("Database type has already been instantiated.");
        DatabaseType = database;
    }
}
