using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using EkDers.Core.Entity;

namespace EkDers.Service.Abstraction
{
    public interface IGenericServices<T> where T : IDbEntity, new()
    {
       Task< IList<T>> GetAllAsync(Expression<Func<T, bool>> expression, params Expression<Func<T, bool>>[] includeproperties);
        Task<T> GetAsync(Expression<Func<T, bool>> expression, params Expression<Func<T, bool>>[] includeproperties);
        Task<T> GetByIdAsync(Guid Id, params Expression<Func<T, bool>>[] includeproperties);
        Task<T> AddAsync(T entity);
        Task<T>UpdateAsync(T entity);
        Task<bool> DeleteAsync(T entity);

    }
}
