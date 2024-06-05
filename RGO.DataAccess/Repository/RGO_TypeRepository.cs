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
    public class RGO_TypeRepository : Repository<RGO_Type>, IRGO_TypeRepository
    {

        private ApplicationDbContext _db;
        public RGO_TypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(RGO_Type obj)
        {
            obj.Updated_Date = DateTime.Now;
            _db.RGO_Types.Update(obj);
        }
    }
}
