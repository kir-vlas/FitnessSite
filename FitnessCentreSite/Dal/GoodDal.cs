using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FitnessCentreSite.Models;
using NHibernate;

namespace FitnessCentreSite.Dal
{
    public class GoodDal : IGoodDal
    {
        public IList<Good> ListAll()
        {
            try
            {
                using (ISession session = NHibernateHelper.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        IList<Good> list = session.CreateQuery("from Good").List<Good>();
                        return list;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Add(Good good)
        {
            try
            {
                using (ISession session = NHibernateHelper.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Save(good);
                        transaction.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(Good good)
        {
            try
            {
                using (ISession session = NHibernateHelper.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Delete(good);
                        transaction.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Good GetOne(int id)
        {
            try
            {
                using (ISession session = NHibernateHelper.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        Good good = session.Get<Good>(id);
                        transaction.Commit();
                        return good;
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