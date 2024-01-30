using RGO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGO.DataAccess.Repository.IRepository
{
    public interface IGroup_TypeRepository : IRepository<Group_Type>
    {
        void Update(Group_Type obj);
    }
}
