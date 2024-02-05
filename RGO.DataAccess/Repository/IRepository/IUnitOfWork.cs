using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGO.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {

        IGroup_TypeRepository Group_Type { get; }
        IGroupRepository Group { get; }
        void Save();
    }
}
