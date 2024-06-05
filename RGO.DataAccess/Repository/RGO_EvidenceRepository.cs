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
    public class RGO_EvidenceRepository : Repository<RGO_Evidence>, IRGO_EvidenceRepository
    {

        private ApplicationDbContext _db;
        public RGO_EvidenceRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(RGO_Evidence obj)
        {
            obj.Updated_Date = DateTime.Now;
            _db.RGO_Evidences.Update(obj);
        }
    }
}
