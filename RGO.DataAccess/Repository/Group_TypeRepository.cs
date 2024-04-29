using Microsoft.EntityFrameworkCore;
using RGO.DataAccess.Data;
using RGO.DataAccess.Repository.IRepository;
using RGO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RGO.DataAccess.Repository
{
    public class Group_TypeRepository : Repository<Group_Type>, IGroup_TypeRepository
    {

        private ApplicationDbContext _db;
        public Group_TypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Group_Type obj)
        {
            
            //foreach(var tracker in _db.ChangeTracker.Entries<Group_Type>())
            //{
            //    Console.WriteLine(tracker.State);
            //}

            //if (_db.Entry(obj).State != EntityState.Unchanged)
            //{
            //    obj.Updated_Date = DateTime.UtcNow;
            //}
            obj.Updated_Date = DateTime.UtcNow;
            _db.Group_Types.Update(obj);
        }
    }
}
