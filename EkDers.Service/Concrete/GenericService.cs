using EkDers.Core.Entity;
using EkDers.Data.Repositories.Abstract;
using EkDers.Data.UnitOfWork;
using EkDers.Entity.DbEntity;
using EkDers.Service.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EkDers.Service.Concrete
{
    public class GenericService<T> : IGenericServices<T> where T : class
        , IDbEntity,  new()
    {
        private readonly IUnitOfWork unitofwork;
        private  IRepository<T> repo;

        public     GenericService(IUnitOfWork unitOfWork)
        {
            this.unitofwork = unitOfWork;
            repo =   unitofwork.GetRepository<T>().Result;
         
        }
      

        public async Task<T> AddAsync(T entity)
        { 
          return await repo.AddAsync(entity);
        }

        public async Task<bool> DeleteAsync(T entity)
        {
         return  await repo.DeleteAsync(entity);
        }

        public async Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> expression, params Expression<Func<T, bool>>[] includeproperties)
        {
            return await repo.GetAllAsync(expression, includeproperties);
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> expression, params Expression<Func<T, bool>>[] includeproperties)
        {
           return await repo.GetAsync(expression, includeproperties);
        }

        public async Task<T> GetByIdAsync(Guid Id, params Expression<Func<T, bool>>[] includeproperties)
        {
            return await repo.GetByIdAsync(Id, includeproperties);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            return await repo.UpdateAsync(entity);
        }
    }
}
