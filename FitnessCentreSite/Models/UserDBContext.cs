using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FitnessCentreSite;
using Microsoft.AspNet.Identity;
using NHibernate;

namespace FitnessCentreSite.Models
{
    public class UserDBContext
    {
        private readonly ISessionFactory sessionFactory;

        public IUserStore<User, int> Users
        {
            get { return new IdentityStore(NHibernateHelper.OpenSession()); }
        }

        public ISession MakeSession()
        {
            return sessionFactory.OpenSession();
        }
    }
}