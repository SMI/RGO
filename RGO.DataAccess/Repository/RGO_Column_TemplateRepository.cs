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
    public class RGO_Column_TemplateRepository : Repository<RGO_Column_Template>, IRGO_Column_TemplateRepository
    {

        private ApplicationDbContext _db;
        public RGO_Column_TemplateRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(RGO_Column_Template obj)
        {
            obj.Updated_Date = DateTime.Now;
            _db.RGO_Column_Templates.Update(obj);
        }
    }
}
