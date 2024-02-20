using RGO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGO.DataAccess.Repository.IRepository
{
    public interface IRGO_TypeRepository : IRepository<RGO_Type>
    {
        void Update(RGO_Type obj);
    }
}
