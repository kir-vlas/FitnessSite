using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FitnessCentreSite.Models;
using NHibernate;

namespace FitnessCentreSite.Dal
{
    public class CategoryDal : ICategoryDal
    {
        public IList<Category> ListAll()
        {
            try
            {
                using (ISession session = NHibernateHelper.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        IList<Category> list = session.CreateQuery("from Category").List<Category>();
                        return list;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Delete(Category category)
        {
            try
            {
                using (ISession session = NHibernateHelper.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Delete(category);
                        transaction.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Add(Category category)
        {
            try
            {
                using (ISession session = NHibernateHelper.OpenSession())
                {
                    using (ITransaction transaction = session.BeginTransaction())
                    {
                        session.Save(category);
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