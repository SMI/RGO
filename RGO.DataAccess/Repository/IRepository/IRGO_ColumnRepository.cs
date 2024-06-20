using RGO.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGO.DataAccess.Repository.IRepository
{
    public interface IRGO_Record_PersonRepository : IRepository<RGO_Record_Person>
    {
        void Update(RGO_Record_Person obj);
        void AddRange(IEnumerable<RGO_Record_Person> records);

    }
}

