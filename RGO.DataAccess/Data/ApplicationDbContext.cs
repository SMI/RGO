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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Group_Type>().HasData(
                new Group_Type { Id = 1, Name = "Research Group", Created_By = "seed", Created_Date = DateTime.UtcNow },
                new Group_Type { Id = 2, Name = "Data Team", Created_By = "seed", Created_Date = DateTime.UtcNow }
                );

           // modelBuilder.Entity<Group_Type>().HasMany(gt => gt.Gr);
            modelBuilder.Entity<Group>().HasData(
                new Group { Id = 1, Group_TypeId = 1, Name = "Classification of Brain Images", Created_By = "seed", Created_Date = DateTime.UtcNow }
                );

            modelBuilder.Entity<Person>().HasData(
                new Person { Id = 1, Name = "Gerry Thomson", ContactInfo = "gerry@yahoo.ac.uk", OrcId = "123ABC", Created_By = "seed", Created_Date = DateTime.UtcNow, Notes= "Academic Neuroradiologist" },
                new Person { Id = 2, Name = "Grant Mair", ContactInfo = "grant@yahoo.ac.uk", OrcId = "456DEF", Created_By = "seed", Created_Date = DateTime.UtcNow, Notes = "Senior Clinical Lecturer in Neuroradiology" },
                new Person { Id = 3, Name = "Smarti Reel", ContactInfo = "smarti@yahoo.ac.uk", OrcId = "", Created_By = "seed", Created_Date = DateTime.UtcNow, Notes = "Postdoctoral Researcher" },
                new Person { Id = 4, Name = "Kara Moraw", ContactInfo = "kara@yahoo.ac.uk", OrcId = "", Created_By = "seed", Created_Date = DateTime.UtcNow, Notes = "EPCC Applications Developer" }
               );

            //modelBuilder.Entity<Group_Role>().HasData(
            //    new Group_Role { Id = 1, Name = "PI", Description = "Principal Investigator", Created_By = "seed", Created_Date = DateTime.UtcNow },
            //    new Group_Role { Id = 2, Name = "RA", Description = "Research Assistant", Created_By = "seed", Created_Date = DateTime.UtcNow },
            //    new Group_Role { Id = 3, Name = "GT", Description = "Ground Truther", Created_By = "seed", Created_Date = DateTime.UtcNow }
            //    );


            //modelBuilder.Entity<Person_Group_Role>().HasData(
            //new Person_Group_Role { Id = 1, Group_Id = 1, Person_Id = 1, Group_Role_Id = 3, Created_By = "seed", Created_Date = DateTime.UtcNow },
            //new Person_Group_Role { Id = 2, Group_Id = 1, Person_Id = 2, Group_Role_Id = 3, Created_By = "seed", Created_Date = DateTime.UtcNow },
            //new Person_Group_Role { Id = 3, Group_Id = 1, Person_Id = 3, Group_Role_Id = 1, Created_By = "seed", Created_Date = DateTime.UtcNow },
            //new Person_Group_Role { Id = 4, Group_Id = 1, Person_Id = 4, Group_Role_Id = 2, Created_By = "seed", Created_Date = DateTime.UtcNow }
            //);

            modelBuilder.Entity<RGO_Type>().HasData(
                new RGO_Type { Id = 1, Name = "Group Truth", Description = "Annotations that have been manually created or validated by a human expert", Created_By = "seed", Created_Date = DateTime.UtcNow }
            );

            modelBuilder.Entity<RGOutput>().HasData(
                new RGOutput { Id = 1, Name = "MRI Classification Group Truth", Description = "Brain Scan Classifications", Originating_GroupId = 1, RGO_TypeId = 1, Created_By = "seed", Created_Date = DateTime.UtcNow }
             );


            modelBuilder.Entity<RGO_Dataset_Template>().HasData(
                new RGO_Dataset_Template { Id = 1, RGOutput_Id = 1, Name = "MRI Classification Group Truth", Description = "Classifying the type of Brain Scans, done by Gerry and Grant", Created_By = "seed", Created_Date = DateTime.UtcNow }
            );

            modelBuilder.Entity<RGO_Column_Template>().HasData(
                //new RGO_Column_Template { Id = 1, RGO_Dataset_TemplateId = 1, Name = "Study_Identifier", Description = "Identifier of the study that this image is part of", PK_Column_Order = 1, Type = "Int", Potentially_Disclosive = "N", Created_By = "seed", Created_Date = DateTime.UtcNow },
                //new RGO_Column_Template { Id = 2, RGO_Dataset_TemplateId = 1, Name = "Series_Identifier", Description = "Identifier of the series that this image is part of", PK_Column_Order = 2, Type = "Int", Potentially_Disclosive = "N", Created_By = "seed", Created_Date = DateTime.UtcNow },
                new RGO_Column_Template { Id = 1, RGO_Dataset_TemplateId = 1, Name = "Image_Identifier", Description = "Identifier of this image", PK_Column_Order = 1, Type = "Int", Potentially_Disclosive = "N", Created_By = "seed", Created_Date = DateTime.UtcNow },
                new RGO_Column_Template { Id = 2, RGO_Dataset_TemplateId = 1, Name = "MRI_Classification", Description = "The ground truth that classifies the type of MRI this is e.g. T1, T2",  Type = "Char", Potentially_Disclosive = "N", Created_By = "seed", Created_Date = DateTime.UtcNow },
                new RGO_Column_Template { Id = 3, RGO_Dataset_TemplateId = 1, Name = "Ground_Truther_1", Description = "An expert who generate this ground truth (1)",  Type = "Int", Potentially_Disclosive = "N", Created_By = "seed", Created_Date = DateTime.UtcNow },
                new RGO_Column_Template { Id = 4, RGO_Dataset_TemplateId = 1, Name = "Ground_Truther_2", Description = "An expert who generate this ground truth (2)", Type = "Int", Potentially_Disclosive = "N", Created_By = "seed", Created_Date = DateTime.UtcNow },
                new RGO_Column_Template { Id = 5, RGO_Dataset_TemplateId = 1, Name = "Date_GT_Recorded", Description = "The date on which this Ground Truth was finalised", Type = "Date", Potentially_Disclosive = "N", Created_By = "seed", Created_Date = DateTime.UtcNow }

            );
        }


    }
}

