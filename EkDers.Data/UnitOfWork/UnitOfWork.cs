using EkDers.Core.Entity;
using EkDers.Data.Context;
using EkDers.Data.Repositories.Concrete;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace EkDers.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
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
            try
            {
                return await ekdersDbContext.SaveChangesAsync();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<RepositoryAsnync<T>> GetRepository<T>() where T : class,IDbEntity,new()   
        {
           var result= await Task.Run(()=>new RepositoryAsnync<T>(ekdersDbContext));
            return result;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

      
    }
}
