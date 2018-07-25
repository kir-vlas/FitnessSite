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
            Bind<ITranersDal>().To<TranersDal>().WithConstructorArgument(connectionString);
            Bind<IGoodDal>().To<GoodDal>().WithConstructorArgument(connectionString);
            Bind<ICategoryDal>().To<CategoryDal>().WithConstructorArgument(connectionString);
            Bind<IBannerDal>().To<BannerDal>().WithConstructorArgument(connectionString);
        }
    }
}