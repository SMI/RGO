using RGO.DataAccess.Data;
using RGO.DataAccess.Repository.IRepository;
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

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Group_Type = new Group_TypeRepository(_db);
            Group = new GroupRepository(_db);

        }

        public void Save() 
        {

            _db.SaveChanges();
        }
    }
}
