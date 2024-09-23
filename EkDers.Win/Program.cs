using DevExpress.Services.Internal;
using DevExpress.Skins;
using DevExpress.UserSkins;
using EkDers.Data.Extensions;
using EkDers.Data.UnitOfWork;
using EkDers.Service.Abstraction;
using EkDers.Service.Concrete ;
using EkDers.Service.Extentions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EkDers.Win
{
    internal static class Program
    {
       
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var serviceprovider = new ServiceCollection();

            DataLayerInjections.LoadServices(serviceprovider);
            ServiceLayerInjections.LoadService(serviceprovider);
           // serviceprovider.AddScoped(typeof(IGenericServices<>), typeof(GenericService<> ));
           // serviceprovider.AddScoped(typeof(IUnitOfWork<>), typeof(UnitOfWork<> ));

            serviceprovider.BuildServiceProvider();
                
                



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
