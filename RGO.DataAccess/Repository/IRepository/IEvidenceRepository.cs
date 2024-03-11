using RGO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGO.DataAccess.Repository.IRepository
{
    public interface IEvidenceRepository : IRepository<Evidence>
    {
        void Update(Evidence obj);
    }
}
