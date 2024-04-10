using RGO.Models;
using RGO.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGO.DataAccess.Repository.IRepository
{
    public interface IRGO_EvidenceRepository : IRepository<RGO_Evidence>
    {
        void Update(RGO_Evidence obj);
    }
}

