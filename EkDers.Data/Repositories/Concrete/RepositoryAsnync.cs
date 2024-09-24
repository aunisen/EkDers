using EkDers.Core.Entity;
using EkDers.Data.Context;
using EkDers.Data.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace EkDers.Data.Repositories.Concrete
{
    public class RepositoryAsnync<T> : IRepository<T> where T : class, IDbEntity,new()
    {
       
        
        private readonly EkdersDbContext _dbContext;
        public RepositoryAsnync(EkdersDbContext ekdersDbContext)
        {
            _dbContext = ekdersDbContext; 
        }
        DbSet<T> GetTable { get { return _dbContext.Set<T>(); } }

        public async  Task<T> AddAsync(T entity)
        {
            var result= await  GetTable.AddAsync(entity);
            return result.Entity;
        }

        public Task<bool> Any(Expression<Func<T, bool>> filter)
        {
           return GetTable.AnyAsync(filter);
            
        }

        public async Task<bool>  DeleteAsync(T entity)
        {
             var result=Task.Run(()=>GetTable.Remove(entity));
            return result.IsFaulted;
        }

       public async Task<IList<T>>  GetAllAsync(Expression<Func<T, bool>> expression=null, params Expression<Func<T, bool>>[] includeproperties)
        {
            var query = GetTable;
            if(expression != null) query.Where(expression);
            if (includeproperties.Any())
            {
                foreach(var property in includeproperties)
                    query.Include(property);
            }
            var result = await query.ToListAsync();
            return result;
        }

       public async Task<T>  GetAsync(Expression<Func<T, bool>> expression, params Expression<Func<T, bool>>[] includeproperties)
        {
            var query = GetTable;
            if (expression != null) query.Where(expression);
            if (includeproperties.Any())
            {
                foreach (var property in includeproperties)
                    query.Include(property);
            }
            var result = await query.SingleOrDefaultAsync();
            return result;
        }

         

       public async Task<T>  GetByIdAsync(Guid Id, params Expression<Func<T, bool>>[] includeproperties)
        {
            var result =await GetTable.SingleOrDefaultAsync(c=>c.Id==Id);  
            return result;
        }

         

        public  async Task<T>   UpdateAsync(T entity)
        {
            var result=await Task.Run(()=>GetTable.Update(entity));
            return result.Entity;
        }

        
    }
}
