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

        public DbSet<Evidence_Type> Evidence_Types { get; set; }

        public DbSet<Evidence> Evidences { get; set; }

        public DbSet<RGO_Evidence> RGO_Evidences { get; set; }

        public DbSet<RGO_Type> RGO_Types { get; set; }

        public DbSet<RGOutput> RGOutputs { get; set; }

        public DbSet<RGO_Dataset_Template> RGO_Dataset_Templates { get; set; }

        public DbSet<RGO_Column_Template> RGO_Column_Templates { get; set; }

        public DbSet<RGO_ReIdentificationConfiguration> RGO_ReIdentification_Configurations { get; set; }

        public DbSet<RGO_Dataset> RGO_Datasets { get; set; }

        public DbSet<RGO_Record> RGO_Records { get; set; }

        public DbSet<RGO_Column> RGO_Columns { get; set; }

        public DbSet<RGO_Record_Person> RGO_Record_People { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Model the FKs (from the viewpoint of the child table)


            //Prevent the deletion of an evidence type, where it is referenced by evidence records
            modelBuilder.Entity<Evidence>()
                .HasOne(e => e.Evidence_Type)
                .WithMany(e => e.Evidence)
                .HasForeignKey("Evidence_TypeId")
                .OnDelete(DeleteBehavior.NoAction); //this should cause a db exception to be propogated

            //Prevent the deletion of an Evidence, where it is referenced by RGO_Evidence records
            modelBuilder.Entity<RGO_Evidence>()
                .HasOne(e => e.Evidence)
                .WithMany(e => e.RGO_Evidence)
                .HasForeignKey("Evidence_Id")
                .OnDelete(DeleteBehavior.NoAction); //this should cause a db exception to be propogated

            //Prevent the deletion of a Person record, where it is referenced by RGO_Record_Person records
            modelBuilder.Entity<RGO_Record_Person>()
                .HasOne(e => e.Person)
                .WithMany(e => e.RGO_Record_Person)
                .HasForeignKey("PersonId")
                .OnDelete(DeleteBehavior.NoAction); //this should cause a db exception to be propogated

            //Prevent the deletion of an RGO_Column_Template record, where it is referenced by RGO_Record_Person records
            modelBuilder.Entity<RGO_Record_Person>()
                .HasOne(e => e.RGO_Column_Template)
                .WithMany(e => e.RGO_Record_Person)
                .HasForeignKey("RGO_Column_TemplateId")
                .OnDelete(DeleteBehavior.NoAction); //this should cause a db exception to be propogated

            //Prevent the deletion of a Group_type record, where it is referenced by Group records
            modelBuilder.Entity<Group>()
                .HasOne(e => e.Group_Type)
                .WithMany(e => e.Group)
                .HasForeignKey("Group_TypeId")
                .OnDelete(DeleteBehavior.NoAction); //this should cause a db exception to be propogated

            //Prevent the deletion of a Group record, where it is referenced by RGOutput records
            modelBuilder.Entity<RGOutput>()
                .HasOne(r => r.Group)
                .WithMany(g => g.RGOutput)
                .HasForeignKey("Originating_GroupId")
                .OnDelete(DeleteBehavior.NoAction); //this should cause a db exception to be propogated

            //Prevent the deletion of an RGO_Type record, where it is referenced by RGOutput records
            modelBuilder.Entity<RGOutput>()
                .HasOne(r => r.RGO_Type)
                .WithMany(t => t.RGOutput)
                .HasForeignKey("RGO_TypeId")
                .OnDelete(DeleteBehavior.NoAction); //this should cause a db exception to be propogated

            //Prevent the deletion of an RGOutput record, where it is referenced by RGO_Dataset_Template records
            modelBuilder.Entity<RGO_Dataset_Template>()
              .HasOne(t => t.RGOutput)
              .WithMany(a => a.RGO_Dataset_Template)
              .HasForeignKey("RGOutput_Id")
              .OnDelete(DeleteBehavior.NoAction); //this should cause a db exception to be propogated

            //Prevent the deletion of an RGO_Dataset_Template record, where it is referenced by RGO_Column_Template records
            modelBuilder.Entity<RGO_Column_Template>()
                 .HasOne(r => r.RGO_Dataset_Template)
                 .WithMany(t => t.RGO_Column_Template)
                 .HasForeignKey("RGO_Dataset_TemplateId")
                 .OnDelete(DeleteBehavior.NoAction); //this should cause a db exception to be propogated

            //Prevent the deletion of an RGO_Dataset_Template record, where it is referenced by RGO_Dataset records
            modelBuilder.Entity<RGO_Dataset>()
                 .HasOne(r => r.RGO_Dataset_Template)
                 .WithMany(t => t.RGO_Dataset)
                 .HasForeignKey("RGO_Dataset_TemplateId")
                 .OnDelete(DeleteBehavior.NoAction); //this should cause a db exception to be propogated

            //Prevent the deletion of an RGO_Column_Template record, where it is referenced by RGO_Column records
            modelBuilder.Entity<RGO_Column>()
                 .HasOne(r => r.RGO_Column_Template)
                 .WithMany(t => t.RGO_Column)
                 .HasForeignKey("RGO_Column_TemplateId")
                 .OnDelete(DeleteBehavior.NoAction); //this should cause a db exception to be propogated

            //Prevent the deletion of an RGO_Column_Template record, where it is referenced by RGO_Record_Person records
            modelBuilder.Entity<RGO_Record_Person>()
                 .HasOne(r => r.RGO_Column_Template)
                 .WithMany(t => t.RGO_Record_Person)
                 .HasForeignKey("RGO_Column_TemplateId")
                 .OnDelete(DeleteBehavior.NoAction); //this should cause a db exception to be propogated



            modelBuilder.Entity<Group>().Navigation(e => e.Group_Type).AutoInclude();
            modelBuilder.Entity<RGOutput>().Navigation(e => e.RGO_Type).AutoInclude();
            modelBuilder.Entity<RGOutput>().Navigation(e => e.Group).AutoInclude();
            modelBuilder.Entity<RGO_Dataset_Template>().Navigation(e => e.RGOutput).AutoInclude();
            modelBuilder.Entity<RGO_Column_Template>().Navigation(e => e.RGO_Dataset_Template).AutoInclude();



  
 

            // Add in the seed data
            modelBuilder.Entity<Group_Type>().HasData(
                new Group_Type { Id = 1, Name = "Research Group", Created_By = "seed", Created_Date = DateTime.UtcNow },
                new Group_Type { Id = 2, Name = "Data Team", Created_By = "seed", Created_Date = DateTime.UtcNow }
                );

            modelBuilder.Entity<Group>().HasData(
                new Group { Id = 1, Group_TypeId = 1, Name = "Classification of Brain Images", Created_By = "seed", Created_Date = DateTime.UtcNow }
                );

            modelBuilder.Entity<Evidence_Type>().HasData(
                new Evidence_Type { Id = 1, Name = "Peer Reviewed Publication", Created_By = "seed", Created_Date = DateTime.UtcNow },
                new Evidence_Type { Id = 2, Name = "Requested by another Research Project", Created_By = "seed", Created_Date = DateTime.UtcNow }
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
                new RGO_Type { Id = 1, Name = "Ground Truth", Description = "Annotations that have been manually created or validated by a human expert", Created_By = "seed", Created_Date = DateTime.UtcNow }
            );

            modelBuilder.Entity<RGOutput>().HasData(
                new RGOutput { Id = 1, Name = "MRI Classification Ground Truth", Description = "Brain Scan Classifications", Originating_GroupId = 1, RGO_TypeId = 1, Created_By = "seed", Created_Date = DateTime.UtcNow }
             );


            modelBuilder.Entity<RGO_Dataset_Template>().HasData(
                new RGO_Dataset_Template { Id = 1, RGOutput_Id = 1, Name = "MRI Classification Ground Truth Template", Description = "Classifying the type of Brain Scans, done by Gerry and Grant", Created_By = "seed", Created_Date = DateTime.UtcNow }
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

