using Microsoft.EntityFrameworkCore;
using RGO.Models;
using RGO.Utility;

namespace RGO.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            switch (DatabaseHelper.Instance.DatabaseType)
            {
                case DatabaseTypes.Postgres:
                    AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
                    break;
                default:
                    break;
            }
        }

        public DbSet<Group_Type> Group_Types { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Group_Type>().HasData(
                new Group_Type { Id = 1, Name = "Research Group", Created_By = "seed", Created_Date = DateTime.Now },
                new Group_Type { Id = 2, Name = "Data Team", Created_By = "seed", Created_Date = DateTime.Now }
                ); ;
        }


    }
}

