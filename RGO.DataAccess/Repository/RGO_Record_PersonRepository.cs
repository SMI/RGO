using RGO.DataAccess.Data;
using RGO.DataAccess.Repository.IRepository;
using RGO.Models;
using RGO.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RGO.DataAccess.Repository
{
    public class RGO_Record_PersonRepository : Repository<RGO_Record_Person>, IRGO_Record_PersonRepository
    {

        private ApplicationDbContext _db;
        public RGO_Record_PersonRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(RGO_Record_Person obj)
        {
            _db.RGO_Record_People.Update(obj);
        }
    }
}
