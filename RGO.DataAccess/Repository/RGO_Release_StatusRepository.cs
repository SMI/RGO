using Microsoft.EntityFrameworkCore;
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
    public class RGO_Release_StatusRepository : Repository<RGO_Release_Status>, IRGO_Release_StatusRepository
    {

        private ApplicationDbContext _db;
        public RGO_Release_StatusRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(RGO_Release_Status obj)
        {
            obj.Updated_Date = DateTime.UtcNow;
            _db.RGO_Release_Statuses.Update(obj);
        }
    }
}
