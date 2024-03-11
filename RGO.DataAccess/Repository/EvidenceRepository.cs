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
    public class EvidenceRepository : Repository<Evidence>, IEvidenceRepository
    {

        private ApplicationDbContext _db;
        public EvidenceRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Evidence obj)
        {
            _db.Evidences.Update(obj);
        }
    }
}
