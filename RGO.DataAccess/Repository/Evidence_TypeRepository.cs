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
    public class Evidence_TypeRepository : Repository<Evidence_Type>, IEvidence_TypeRepository
    {

        private ApplicationDbContext _db;
        public Evidence_TypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Evidence_Type obj)
        {
            _db.Evidence_Types.Update(obj);
        }
    }
}
