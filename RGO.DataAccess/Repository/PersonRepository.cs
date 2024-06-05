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
    public class PersonRepository : Repository<Person>, IPersonRepository
    {

        private ApplicationDbContext _db;
        public PersonRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Person obj)
        {
            obj.Updated_Date = DateTime.Now;
            _db.People.Update(obj);
        }
    }
}
