using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject;
using System.Web.Mvc;
using FitnessCentreSite.Service;

namespace FitnessCentreSite.Util
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }
        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
        private void AddBindings()
        {
            kernel.Bind<IAbonOrderService>().To<AbonOrderService>();
            kernel.Bind<ITranerService>().To<TranerService>();
            kernel.Bind<ICategoryService>().To<CategoryService>();
            kernel.Bind<IGoodService>().To<GoodService>();
            kernel.Bind<IBannerService>().To<BannerService>();
        }
    }
}