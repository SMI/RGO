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
        //IEnumerable<TEntity> GetAll(string? includeProperties = null);
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter = null, string? includeProperties = null);
        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> filter, string? includeProperties = null);
        void Add(TEntity entity);
        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entity);
    }
}
