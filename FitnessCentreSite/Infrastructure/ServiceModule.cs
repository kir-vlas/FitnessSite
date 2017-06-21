using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject.Modules;
using FitnessCentreSite.Dal;

namespace FitnessCentreSite.Infrastructure
{
    public class ServiceModule : NinjectModule
    {
        private string connectionString;
        public ServiceModule(string connection)
        {
            connectionString = connection;
        }
        public override void Load()
        {
            Bind<IAbonOrdersDal>().To<AbonOrdersDal>().WithConstructorArgument(connectionString);
        }
    }
}