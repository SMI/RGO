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

        public IRGO_TypeRepository RGO_Type { get; private set; }

        public IRGO_Dataset_TemplateRepository RGO_Dataset_Template { get; private set; }
        public IRGO_Column_TemplateRepository RGO_Column_Template { get; private set; }

        public IRGO_OutputRepository RGO_Output { get; private set; }


        public IRGO_DatasetRepository RGO_Dataset { get; private set; }
        public IRGO_RecordRepository RGO_Record { get; private set; }
        public IRGO_ColumnRepository RGO_Column { get; private set; }

        public IPersonRepository Person { get; private set; }

        public IRGO_Record_PersonRepository RGO_Record_Person { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Group_Type = new Group_TypeRepository(_db);
            Group = new GroupRepository(_db);
            RGO_Type = new RGO_TypeRepository(_db);
            RGO_Dataset_Template = new RGO_Dataset_TemplateRepository(_db);
            RGO_Column_Template = new RGO_Column_TemplateRepository(_db);
            RGO_Dataset = new RGO_DatasetRepository(_db);
            RGO_Record = new RGO_RecordRepository(_db);
            RGO_Column = new RGO_ColumnRepository(_db);
            Person = new PersonRepository(_db);
            RGO_Record_Person = new RGO_Record_PersonRepository(_db);
            RGO_Output = new RGO_OutputRepository(_db);

        }

        public void Save() 
        {

            _db.SaveChanges();
        }
    }
}
