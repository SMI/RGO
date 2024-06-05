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
    public class RGO_RecordRepository : Repository<RGO_Record>, IRGO_RecordRepository
    {

        private ApplicationDbContext _db;
        public RGO_RecordRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(RGO_Record obj)
        {
            obj.Updated_Date = DateTime.Now;
            _db.RGO_Records.Update(obj);
        }
    }
}
