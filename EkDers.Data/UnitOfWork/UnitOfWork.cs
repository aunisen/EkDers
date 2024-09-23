using EkDers.Core.Entity;
using EkDers.Data.Context;
using EkDers.Data.Repositories.Concrete;

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
          return  await ekdersDbContext.SaveChangesAsync();
        }

        public async Task<Repository<T>> GetRepository<T>() where T : class,IDbEntity,new()   
        {
           var result= await Task.Run(()=>new Repository<T>(ekdersDbContext));
            return result;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
