using RGO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGO.DataAccess.Repository.IRepository
{
    public interface IEvidence_TypeRepository : IRepository<Evidence_Type>
    {
        void Update(Evidence_Type obj);
    }
}
