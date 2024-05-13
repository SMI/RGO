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


        public DbSet<RGO_Type> RGO_Types { get; set; }

        public DbSet<RGOutput> RGOutputs { get; set; }


        public DbSet<RGO_Evidence> RGO_Evidences { get; set; }

        public DbSet<RGO_Dataset_Template> RGO_Dataset_Templates { get; set; }

        public DbSet<RGO_Column_Template> RGO_Column_Templates { get; set; }

        public DbSet<RGO_ReIdentificationConfiguration> RGO_ReIdentification_Configurations { get; set; }

        public DbSet<RGO_Dataset> RGO_Datasets { get; set; }

        public DbSet<RGO_Record> RGO_Records { get; set; }

        public DbSet<RGO_Column> RGO_Columns { get; set; }

        public DbSet<RGO_Record_Person> RGO_Record_People { get; set; }

        public DbSet<RGO_Release_Status> RGO_Release_Statuses { get; set; }


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

            //Prevent the deletion of an RGOutput, where it is referenced by RGO_Evidence records
            modelBuilder.Entity<RGO_Evidence>()
                .HasOne(e => e.RGOutput)
                .WithMany(e => e.RGO_Evidence)
                .HasForeignKey("RGOutput_Id")
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

            //Prevent the deletion of an RGO_ReIdentificationConfiguration record, where it is referenced by RGO_Dataset records
            modelBuilder.Entity<RGO_Dataset>()
                 .HasOne(r => r.RGO_ReIdentificationConfiguration)
                 .WithMany(t => t.RGO_Dataset)
                 .HasForeignKey("RGO_ReIdentificationConfigurationId")
                 .OnDelete(DeleteBehavior.NoAction); //this should cause a db exception to be propogated

            //Prevent the deletion of an RGO_Column_Template record, where it is referenced by RGO_Column records
            modelBuilder.Entity<RGO_Column>()
                 .HasOne(r => r.RGO_Column_Template)
                 .WithMany(t => t.RGO_Column)
                 .HasForeignKey("RGO_Column_TemplateId")
                 .OnDelete(DeleteBehavior.NoAction); //this should cause a db exception to be propogated

            //Prevent the deletion of a Release Status, where it is referenced by an RGO_Dataset_Template record
            modelBuilder.Entity<RGO_Dataset_Template>()
                .HasOne(r => r.RGO_Release_Status)
                .WithMany(t => t.RGO_Dataset_Template)
                .HasForeignKey("Release_Status_Id")
                .OnDelete(DeleteBehavior.NoAction); //this should cause a db exception to be propogated

            //Prevent the deletion of a Release Status, where it is referenced by an RGO_Column_Template record
            modelBuilder.Entity<RGO_Column_Template>()
                .HasOne(r => r.RGO_Release_Status)
                .WithMany(t => t.RGO_Column_Template)
                .HasForeignKey("Release_Status_Id")
                .OnDelete(DeleteBehavior.NoAction); //this should cause a db exception to be propogated

            //Prevent the deletion of a Release Status, where it is referenced by an RGO_Dataset record
            modelBuilder.Entity<RGO_Dataset>()
                .HasOne(r => r.RGO_Release_Status)
                .WithMany(t => t.RGO_Dataset)
                .HasForeignKey("Release_Status_Id")
                .OnDelete(DeleteBehavior.NoAction); //this should cause a db exception to be propogated

            ////Prevent the deletion of a Release Status, where it is referenced by an RGO_Column record
            //modelBuilder.Entity<RGO_Column>()
            //    .HasOne(r => r.RGO_Release_Status)
            //    .WithMany(t => t.RGO_Column)
            //    .HasForeignKey("Release_Status_Id")
            //    .OnDelete(DeleteBehavior.NoAction); //this should cause a db exception to be propogated


            ////Prevent the deletion of a Release Status, where it is referenced by an RGO_Record_Person record
            //modelBuilder.Entity<RGO_Record_Person>()
            //    .HasOne(r => r.RGO_Release_Status)
            //    .WithMany(t => t.RGO_Record_Person)
            //    .HasForeignKey("Release_Status_Id")
            //    .OnDelete(DeleteBehavior.NoAction); //this should cause a db exception to be propogated



            modelBuilder.Entity<Group>().Navigation(e => e.Group_Type).AutoInclude();
            modelBuilder.Entity<RGOutput>().Navigation(e => e.RGO_Type).AutoInclude();
            modelBuilder.Entity<RGOutput>().Navigation(e => e.Group).AutoInclude();
            modelBuilder.Entity<RGO_Dataset_Template>().Navigation(e => e.RGOutput).AutoInclude();
            modelBuilder.Entity<RGO_Dataset_Template>().Navigation(e => e.RGO_Release_Status).AutoInclude();
            modelBuilder.Entity<RGO_Column_Template>().Navigation(e => e.RGO_Dataset_Template).AutoInclude();
            modelBuilder.Entity<RGO_Column_Template>().Navigation(e => e.RGO_Release_Status).AutoInclude();






            // Add in the seed data
            //modelBuilder.Entity<Group_Type>().HasData(
            //    new Group_Type { Id = 1, Name = "Research Group", Created_By = "seed", Created_Date = DateTime.UtcNow },
            //    new Group_Type { Id = 2, Name = "Data Team", Created_By = "seed", Created_Date = DateTime.UtcNow }
            //    );

            //modelBuilder.Entity<Group>().HasData(
            //    new Group { Id = 1, Group_TypeId = 1, Name = "Classification of Brain Images", Created_By = "seed", Created_Date = DateTime.UtcNow }
            //    );

            //modelBuilder.Entity<Evidence_Type>().HasData(
            //    new Evidence_Type { Id = 1, Name = "Peer Reviewed Publication", Created_By = "seed", Created_Date = DateTime.UtcNow },
            //    new Evidence_Type { Id = 2, Name = "Requested by another Research Project", Created_By = "seed", Created_Date = DateTime.UtcNow }
            //    );


            //modelBuilder.Entity<Person>().HasData(
            //    new Person { Id = 1, Name = "Gerry Thomson",  OrcId = "123ABC", Created_By = "seed", Created_Date = DateTime.UtcNow, Notes= "Academic Neuroradiologist" },
            //    new Person { Id = 2, Name = "Grant Mair",  OrcId = "456DEF", Created_By = "seed", Created_Date = DateTime.UtcNow, Notes = "Senior Clinical Lecturer in Neuroradiology" },
            //    new Person { Id = 3, Name = "Smarti Reel",  OrcId = "", Created_By = "seed", Created_Date = DateTime.UtcNow, Notes = "Postdoctoral Researcher" },
            //    new Person { Id = 4, Name = "Kara Moraw",  OrcId = "", Created_By = "seed", Created_Date = DateTime.UtcNow, Notes = "EPCC Applications Developer" }
            //   );


            //modelBuilder.Entity<RGO_Type>().HasData(
            //    new RGO_Type { Id = 1, Name = "Ground Truth", Description = "Annotations that have been manually created or validated by a human expert", Created_By = "seed", Created_Date = DateTime.UtcNow }
            //);

            //modelBuilder.Entity<RGOutput>().HasData(
            //    new RGOutput { Id = 1, Name = "MRI Classification Ground Truth", Description = "Brain Scan Classifications", Originating_GroupId = 1, RGO_TypeId = 1, Created_By = "seed", Created_Date = DateTime.UtcNow }
            // );


            //modelBuilder.Entity<RGO_Dataset_Template>().HasData(
            //    new RGO_Dataset_Template { Id = 1, RGOutput_Id = 1, Name = "MRI Classification Ground Truth Template", Description = "Classifying the type of Brain Scans, done by Gerry and Grant", Created_By = "seed", Created_Date = DateTime.UtcNow, Release_Status_Id = 1 }
            //);

            //modelBuilder.Entity<RGO_Column_Template>().HasData(
            //    new RGO_Column_Template { Id = 1, RGO_Dataset_TemplateId = 1, Name = "Image_Identifier", Description = "Identifier of this image", PK_Column_Order = 1, Type = "Int", Potentially_Disclosive = "N", Created_By = "seed", Created_Date = DateTime.UtcNow, Release_Status_Id = 1 },
            //    new RGO_Column_Template { Id = 2, RGO_Dataset_TemplateId = 1, Name = "MRI_Classification_Ground_Truther_1", Description = "The first ground truther's label",  Type = "Char", Potentially_Disclosive = "N", Created_By = "seed", Created_Date = DateTime.UtcNow, Release_Status_Id = 1 },
            //    new RGO_Column_Template { Id = 3, RGO_Dataset_TemplateId = 1, Name = "MRI_Classification_Ground_Truther_2", Description = "The second ground truther's label", Type = "Char", Potentially_Disclosive = "N", Created_By = "seed", Created_Date = DateTime.UtcNow, Release_Status_Id = 1 },
            //    new RGO_Column_Template { Id = 4, RGO_Dataset_TemplateId = 1, Name = "MRI_Classification_Consensus", Description = "This holds labels where both ground truthers agreed", Type = "Char", Potentially_Disclosive = "N", Created_By = "seed", Created_Date = DateTime.UtcNow, Release_Status_Id = 1 }

            //);

            //modelBuilder.Entity<RGO_Release_Status>().HasData(
            //    new RGO_Release_Status { Id = 1, Name = "Held", Description = "See Notes for reasons", Created_By = "seed"},
            //    new RGO_Release_Status { Id = 2, Name = "Released", Description = "Available for other researchers", Available_For_Release = "Y", Created_By = "seed" }
            //);
        }


    }
}

