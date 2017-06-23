using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FitnessCentreSite.Dal;
using FitnessCentreSite.Models;

namespace FitnessCentreSite.Service
{
    public class GoodService : IGoodService
    {
        IGoodDal Database { get; set; }

        public GoodService(IGoodDal d)
        {
            Database = d;
        }

        public IList<Good> ListAll()
        {
            return Database.ListAll();
        }

        public void Add(Good good)
        {
            Database.Add(good);
        }

        public void Delete(Good good)
        {
            Database.Delete(good);
        }

        public Good GetOne(int id)
        {
            return Database.GetOne(id);
        }
    }
}