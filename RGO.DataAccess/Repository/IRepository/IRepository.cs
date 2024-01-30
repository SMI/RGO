using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RGO.DataAccess.Repository.IRepository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        //TEntity - Group Type
        IEnumerable<TEntity> GetAll();
        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> filter);
        void Add(TEntity entity);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entity);
    }
}
