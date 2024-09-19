using EkDers.Core.Entity;
using EkDers.Data.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkDers.Data.UnitOfWork
{
    public interface IUnitOfWork<T>:IAsyncDisposable where T:class,IDbEntity,new()   
    {
       Task< IRepository<T>> GetRepository<T>() where T:class, IDbEntity, new();
        Task<int> SaveAsync();
    }
}
