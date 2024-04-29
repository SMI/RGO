using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Storage;
using RGO.DataAccess.Data;
using RGO.DataAccess.Repository.IRepository;
using RGO.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGO.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;

        public IGroup_TypeRepository Group_Type { get; private set; }
        public IGroupRepository Group { get; private set; }

        public IEvidence_TypeRepository Evidence_Type { get; private set; }
        public IEvidenceRepository Evidence { get; private set; }

        public IRGO_TypeRepository RGO_Type { get; private set; }

        public IRGOutputRepository RGOutput { get; private set; }

        public IRGO_Dataset_TemplateRepository RGO_Dataset_Template { get; private set; }
        public IRGO_Column_TemplateRepository RGO_Column_Template { get; private set; }

        public IRGO_OutputRepository RGO_Output { get; private set; }


        public IRGO_DatasetRepository RGO_Dataset { get; private set; }
        public IRGO_RecordRepository RGO_Record { get; private set; }
        public IRGO_ColumnRepository RGO_Column { get; private set; }

        public IRGO_EvidenceRepository RGO_Evidence { get; private set; }

        public IPersonRepository Person { get; private set; }

        public IRGO_Record_PersonRepository RGO_Record_Person { get; private set; }
        public IRGO_ReIdentificationConfigurationRepository RGO_ReIdentificationConfiguration { get; private set; }
        public IRGO_Release_StatusRepository RGO_Release_Status { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Group_Type = new Group_TypeRepository(_db);
            Group = new GroupRepository(_db);
            Evidence_Type = new Evidence_TypeRepository(_db);
            Evidence = new EvidenceRepository(_db);
            RGO_Type = new RGO_TypeRepository(_db);
            RGOutput = new RGOutputRepository(_db);
            RGO_Dataset_Template = new RGO_Dataset_TemplateRepository(_db);
            RGO_Column_Template = new RGO_Column_TemplateRepository(_db);
            RGO_Dataset = new RGO_DatasetRepository(_db);
            RGO_Record = new RGO_RecordRepository(_db);
            RGO_Column = new RGO_ColumnRepository(_db);
            Person = new PersonRepository(_db);
            RGO_Record_Person = new RGO_Record_PersonRepository(_db);
            RGO_Output = new RGO_OutputRepository(_db);
            RGO_Evidence = new RGO_EvidenceRepository(_db);
            RGO_ReIdentificationConfiguration = new RGO_ReIdentificationConfigurationRepository(_db);
            RGO_Release_Status = new RGO_Release_StatusRepository(_db);

        }

        public void Save() 
        {
            //ProcessSave();
            //_db.ChangeTracker.DetectChanges();
            //if (_db.ChangeTracker.DebugView.LongView == "Modified")
            //Console.WriteLine(_db.ChangeTracker.DebugView.LongView);
            //var entries = _db.ChangeTracker.Entries().Where(e => e.Entity is Entity && (
            //e.State == EntityState.Added || e.State == EntityState.Modified));

            //foreach (var entityEntry in entries)
            //{
            //    ((Entity)entityEntry.Entity).Updated_Date = DateTime.UtcNow;

            //    if (entityEntry.State == EntityState.Added)
            //    {
            //        ((Entity)entityEntry.Entity).Created_Date = DateTime.UtcNow;
            //    }
            //}

            _db.SaveChanges();
        }

        //private void ProcessSave()
        //{
        //    var thisTime = DateTime.UtcNow;
        //    foreach (var item in ChangeTracker.Entries()
        //        .Where(e => e.State == EntityState.Added && e.Entity is Entity))
        //    {
        //        var entity = item.Entity as Entity;
        //        entity.Created_Date = thisTime;
        //    }
        //    foreach (var item in ChangeTracker.Entries()
        //    .Where(e => e.State == EntityState.Modified && e.Entity is Entity))
        //    {
        //        var entity = item.Entity as Entity;
        //        entity.Updated_Date = thisTime;
        //        item.Property(nameof(entity.Created_Date)).isModified = false;
        //        //item.Property(nameof(entity.Created_By)).isModified = false;

        //    }
        //}

    }
}
