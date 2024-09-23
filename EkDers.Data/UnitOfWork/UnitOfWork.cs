using EkDers.Core.Entity;
using EkDers.Data.Context;
using EkDers.Data.Repositories.Abstract;
using EkDers.Data.Repositories.Concrete;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace EkDers.Data.UnitOfWork
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T:class,IDbEntity,new()
    {
        //public static ServiceProvider ServiceProvider { get; private set; }
        private readonly EkdersDbContext ekdersDbContext;

        public UnitOfWork()
        {
            ekdersDbContext = new EkdersDbContext();
            //ServiceProvider=new ServiceCollection().AddScoped<IRepository<T>,Repository<T>>().BuildServiceProvider();
             
        }
        public async ValueTask DisposeAsync()
        {
            await Task.Run(() => { this.ekdersDbContext.Dispose(); });
            GC.SuppressFinalize(this);
        }

        public async Task<int> SaveAsync()
        {
          return  await ekdersDbContext.SaveChangesAsync();
        }

        public async Task<IRepository<T>> GetRepository<T>() where T : class,IDbEntity,new()   
        {
           var result= await Task.Run(()=>new Repository<T>(ekdersDbContext));
            return result;
        }
 
    }
}
