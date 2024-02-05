using Microsoft.EntityFrameworkCore;
using RGO.DataAccess.Data;
using RGO.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RGO.DataAccess.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly ApplicationDbContext _db;

        internal DbSet<TEntity> dbSet;

        public Repository(ApplicationDbContext db)
        {
            _db = db;
            //dbset is generic - will be set to the correct entity type i.e. indicated by TEntity
            this.dbSet = _db.Set<TEntity>();
            _db.Groups.Include(u => u.Group_Type);

        }

        public void Add(TEntity entity)
        {
            dbSet.Add(entity);
        }

        public IEnumerable<TEntity> GetAll(string? includeProperties = null)
        {
            IQueryable<TEntity> query = dbSet;
            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach(var includeProp in includeProperties.Split(new char[] {','}, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp);
                }
            }
            return query.ToList();
        }

        public TEntity FirstOrDefault(Expression<Func<TEntity, bool>> filter, string? includeProperties = null)
        {
            IQueryable<TEntity> query = dbSet;
            query = query.Where(filter);
            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp);
                }
            }
            return query.FirstOrDefault();
        }

        public void Remove(TEntity entity)
        {
            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entity)
        {
            dbSet.RemoveRange(entity);
        }
    }
}
