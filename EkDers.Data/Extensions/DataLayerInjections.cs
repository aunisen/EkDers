using EkDers.Data.UnitOfWork;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EkDers.Data.Extensions
{
    public static class DataLayerInjections
    {
        public static ServiceCollection LoadServices(this ServiceCollection collection)
        {
           // collection.AddScoped(typeof(IUnitOfWork<>),typeof(UnitOfWork<>));
            return collection;  
        }
    }
}
