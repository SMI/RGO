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
    public class RGO_ReIdentificationConfigurationRepository: Repository<RGO_ReIdentificationConfiguration>, IRGO_ReIdentificationConfigurationRepository
    {

        private ApplicationDbContext _db;
        public RGO_ReIdentificationConfigurationRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(RGO_ReIdentificationConfiguration obj)
        {
            _db.RGO_ReIdentification_Configurations.Update(obj);
        }
    }
}
