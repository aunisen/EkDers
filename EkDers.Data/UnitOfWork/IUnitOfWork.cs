using EkDers.Core.Entity;
using EkDers.Data.Repositories.Abstract;
using EkDers.Data.Repositories.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkDers.Data.UnitOfWork
{
    public interface IUnitOfWork:IAsyncDisposable    
    {
       Task<Repository<T>> GetRepository<T>() where T:class, IDbEntity, new();
        Task<int> SaveAsync();
    }
}
