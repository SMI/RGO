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
    public class RGO_Dataset_TemplateRepository : Repository<RGO_Dataset_Template>, IRGO_Dataset_TemplateRepository
    {

        private ApplicationDbContext _db;
        public RGO_Dataset_TemplateRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(RGO_Dataset_Template obj)
        {
            _db.RGO_Dataset_Templates.Update(obj);
        }
    }
}
