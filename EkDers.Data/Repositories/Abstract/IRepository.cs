using EkDers.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EkDers.Data.Repositories.Abstract
{
    public interface IRepository<T> where T :class, IDbEntity,new()
    {
       Task< IList<T>> GetAllAsync(Expression<Func<T, bool>> expression, params Expression<Func<T, bool>>[] includeproperties);
        Task<T> GetAsync(Expression<Func<T, bool>> expression, params Expression<Func<T, bool>>[] includeproperties);
        Task<T> GetByIdAsync(Guid Id, params Expression<Func<T, bool>>[] includeproperties);
        Task<bool> Any(Expression<Func<T, bool>> filter);
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<bool> DeleteAsync(T entity);
    }
}
