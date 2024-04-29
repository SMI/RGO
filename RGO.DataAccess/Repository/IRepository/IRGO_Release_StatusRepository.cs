using RGO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGO.DataAccess.Repository.IRepository
{
    public interface IRGO_Release_StatusRepository : IRepository<RGO_Release_Status>
    {
        void Update(RGO_Release_Status obj);
    }
}
