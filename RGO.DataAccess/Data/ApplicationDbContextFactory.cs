using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace RGO.DataAccess.Data
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            var dbType = builder.Configuration.GetValue(typeof(object), "DatabaseType");
            switch (dbType)
            {
                case nameof(DatabaseTypes.MicrosoftSQL):
                    optionsBuilder.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
                    DatabaseHelper.Instance.SetDatabaseType(DatabaseTypes.MicrosoftSQL);
                    break;
                case nameof(DatabaseTypes.Postgres):
                    optionsBuilder.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
                    DatabaseHelper.Instance.SetDatabaseType(DatabaseTypes.Postgres);
                    break;
                default:
                    throw new Exception($"Unknown database type '{dbType}'");
            }
            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
