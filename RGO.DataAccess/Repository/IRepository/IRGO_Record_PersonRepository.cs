using RGO.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGO.DataAccess.Repository.IRepository
{
    public interface IRGO_ColumnRepository : IRepository<RGO_Column>
    {
        void Update(RGO_Column obj);

        void AddRange(IEnumerable<RGO_Column> records);
    }
}

