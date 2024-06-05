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
    public class RGO_OutputRepository : Repository<RGOutput>, IRGO_OutputRepository
    {

        private ApplicationDbContext _db;
        public RGO_OutputRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(RGOutput obj)
        {
            obj.Updated_Date = DateTime.Now;
            _db.RGOutputs.Update(obj);
        }
    }
}
