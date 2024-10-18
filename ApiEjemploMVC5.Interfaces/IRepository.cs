using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ApiEjemploMVC5.Interfaces
{
    public interface IRepository<T> where T : class
    {
        // Get by Id
        T GetById(int id);
        // Get all
        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeProperties = null
        );
        // Get first or default
        T GetFirstOrDefault(
            Expression<Func<T, bool>> filter = null,
            string includeProperties = null
        );
        // Add
        void Add(T entity);
        // Remove by Id
        void Delete(int id);
        // Remove by entity
        void Delete(T entity);
    }
}
