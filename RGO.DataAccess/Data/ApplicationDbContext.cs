using Microsoft.EntityFrameworkCore;
using RGO.Models;
using RGO.Models.Models;

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
        public DbSet<Group> Groups { get; set; }

        public DbSet<Person> People { get; set; }


        //public DbSet<Group_Role> Group_Roles { get; set; }

        //public DbSet<Person_Group_Role> People_Group_Roles { get; set; }

        public DbSet<RGO_Type> RGO_Types { get; set; }

        public DbSet<RGOutput> RGOutputs { get; set; }

        public DbSet<RGO_Dataset_Template> RGO_Dataset_Templates { get; set; }

        public DbSet<RGO_Column_Template> RGO_Column_Templates { get; set; }

        public DbSet<RGO_Dataset> RGO_Datasets { get; set; }

        public DbSet<RGO_Record> RGO_Records { get; set; }

        public DbSet<RGO_Column> RGO_Columns { get; set; }

        public DbSet<RGO_Record_Person> RGO_Record_People { get; set; }
        public DbSet<RGO_ReIdentificationConfiguration> RGO_ReIdentification_Configurations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Group>()
                .HasOne(gt =>gt.Group_Type)
                .WithMany(t => t.Groups)
                .HasForeignKey(gt => gt.Group_TypeId)
                .OnDelete(DeleteBehavior.NoAction); //this should cause a db exception to be propogated

            modelBuilder.Entity<RGOutput>()
                .HasOne(g => g.Group)
                .WithMany(r => r.RGOutputs)
                .HasForeignKey(r => r.Originating_GroupId)
                .OnDelete(DeleteBehavior.NoAction); //this should cause a db exception to be propogated
        }


    }
}

