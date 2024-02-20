using RGO.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGO.DataAccess.Repository.IRepository
{
    public interface IRGO_Column_TemplateRepository : IRepository<RGO_Column_Template>
    {
        void Update(RGO_Column_Template obj);
    }
}

