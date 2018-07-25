using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Mapping.Attributes;
using FitnessCentreSite.Models;

namespace FitnessCentreSite
{
    public class NHibernateHelper
    {
        public static ISession OpenSession()
        {
            var configuration = new Configuration();
            var configurePath = HttpContext.Current.Server.MapPath(@"~\Models\Nhibernate\nhibernate.cfg.xml");
            configuration.Configure(configurePath);
            HbmSerializer.Default.Validate = true;
            var stream = HbmSerializer.Default.Serialize(Assembly.GetAssembly(typeof(Category)));
            configuration.AddInputStream(stream);
            ISessionFactory sessionFactory = configuration.BuildSessionFactory();
            return sessionFactory.OpenSession();
        }
    }
}
