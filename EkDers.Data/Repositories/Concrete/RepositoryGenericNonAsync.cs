using EkDers.Core.Entity;
using EkDers.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace EkDers.Data.Repositories.Concrete
{
    public  class RepositoryGenericNonAsync<T> where T : class, IDbEntity, new()  
    {
        private readonly EkdersDbContext _dbContext;
        public RepositoryGenericNonAsync()
        {
            _dbContext = new EkdersDbContext(); 
        }
        DbSet<T> GetTable { get { return _dbContext.Set<T>(); } }

        public T Add(T entity)
        {
             GetTable.Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public bool  Any(Expression<Func<T, bool>> filter)
        {
            return GetTable.Any(filter);

        }

        public bool Delete(T entity)
        {
            GetTable.Remove(entity) ;
            return _dbContext.SaveChanges() > 0;
        }

        public IList<T> GetAll(Expression<Func<T, bool>> expression = null, params Expression<Func<T, bool>>[] includeproperties)
        {
            var query = GetTable;
            if (expression != null) query.Where(expression);
            if (includeproperties.Any())
            {
                foreach (var property in includeproperties)
                    query.Include(property);
            }
           return query.ToList();
              
            
             
        }

        public T? Get(Expression<Func<T, bool>> expression, params Expression<Func<T, bool>>[] includeproperties)
        {
            var query = GetTable;
            if (expression != null) query.Where(expression);
            if (includeproperties.Any())
            {
                foreach (var property in includeproperties)
                    query.Include(property);
            }
            return query.SingleOrDefault();
            
        }



        public T? GetById(Guid Id, params Expression<Func<T, bool>>[] includeproperties)
        {
            var query = GetTable;
            if (includeproperties.Any())
            {
                foreach (var property in includeproperties)
                    query.Include(property);
            }

            return query.SingleOrDefault(c => c.Id == Id);
        }



        public T Update(T entity)
        {
            GetTable.Update(entity);   
            _dbContext.SaveChanges();   
           return   Update(entity);
             
        }

    }
}
