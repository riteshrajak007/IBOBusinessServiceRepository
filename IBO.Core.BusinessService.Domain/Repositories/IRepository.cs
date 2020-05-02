using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace IBO.Core.BusinessService.Domain.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        //IQueryable<T> FindAll();
        //IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
        //void Create(T entity);
        //void Update(T entity);
        //void Delete(T entity);
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);
        void Update(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}
