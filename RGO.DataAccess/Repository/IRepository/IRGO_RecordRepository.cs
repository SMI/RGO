using RGO.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGO.DataAccess.Repository.IRepository
{
    public interface IRGO_RecordRepository : IRepository<RGO_Record>
    {
        void Update(RGO_Record obj);
    }
}

