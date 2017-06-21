using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate;
using FitnessCentreSite.Models;

namespace FitnessCentreSite.Dal
{
    public class AbonOrdersDal : IAbonOrdersDal
    {
        public void Save(AbonOrder abonOrder)
        {
            try
            {
                using (ISession session = NHibernateHelper.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Save(abonOrder);
                        transaction.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}