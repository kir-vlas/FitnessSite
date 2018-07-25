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
        public void Delete(AbonOrder abonOrder)
        {
            try
            {
                using (ISession session = NHibernateHelper.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Delete(abonOrder);
                        transaction.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public AbonOrder GetOne(int id)
        {
            try
            {
                using (ISession session = NHibernateHelper.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        AbonOrder result = session.Get<AbonOrder>(id);
                        transaction.Commit();
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<AbonOrder> ListAll()
        {
            try
            {
                using (ISession session = NHibernateHelper.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        IList<AbonOrder> list = session.CreateQuery("from AbonOrder").List<AbonOrder>();
                        return list;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

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

        public void Update(AbonOrder abonOrder)
        {
            try
            {
                using (ISession session = NHibernateHelper.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.SaveOrUpdate(abonOrder);
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