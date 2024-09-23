using EkDers.Service.Abstraction;
using EkDers.Service.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkDers.Service.Extentions
{
    public static class ServiceLayerInjections
    {
        public static ServiceCollection LoadService(this ServiceCollection services)
        {
            services.AddScoped(typeof(IGenericServices<>), typeof(GenericService<>));
            return services;
        }
    }
}
