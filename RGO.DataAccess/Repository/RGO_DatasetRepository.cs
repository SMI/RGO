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
    public class RGO_DatasetRepository : Repository<RGO_Dataset>, IRGO_DatasetRepository
    {

        private ApplicationDbContext _db;
        public RGO_DatasetRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(RGO_Dataset obj)
        {
            _db.RGO_Datasets.Update(obj);
        }
    }
}
