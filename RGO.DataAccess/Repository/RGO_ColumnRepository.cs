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
    public class RGO_ColumnRepository : Repository<RGO_Column>, IRGO_ColumnRepository
    {

        private ApplicationDbContext _db;
        public RGO_ColumnRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(RGO_Column obj)
        {
            _db.RGO_Columns.Update(obj);
        }
    }
}
