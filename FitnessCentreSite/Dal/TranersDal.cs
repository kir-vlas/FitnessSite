using FitnessCentreSite.Models;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitnessCentreSite.Dal
{
    public class TranersDal : ITranersDal
    {
        public void Delete(Traner traner)
        {
            try
            {
                using (ISession session = NHibernateHelper.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Delete(traner);
                        transaction.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Traner GetTraner(int id)
        {
            try
            {
                using (ISession session = NHibernateHelper.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        Traner traner = session.Get<Traner>(id);
                        transaction.Commit();
                        return traner;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<Traner> ListAll()
        {
            try
            {
                using (ISession session = NHibernateHelper.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        IList<Traner> list = session.CreateQuery("from Traner").List<Traner>();
                        transaction.Commit();
                        return list;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Save(Traner traner)
        {
            try
            {
                using (ISession session = NHibernateHelper.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Save(traner);
                        transaction.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Traner traner)
        {
            try
            {
                using (ISession session = NHibernateHelper.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.SaveOrUpdate(traner);
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