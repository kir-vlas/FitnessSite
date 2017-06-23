using FitnessCentreSite.Models;
using FitnessCentreSite.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitnessCentreSite.Service
{
    public class AbonOrderService : IAbonOrderService
    {
        IAbonOrdersDal Database { get; set; }

        public AbonOrderService(IAbonOrdersDal d)
        {
            Database = d;
        }

        public void Save(AbonOrder abonOrder)
        {
            Database.Save(abonOrder);
        }

        public IList<AbonOrder> ListAll()
        {
            return Database.ListAll();
        }

        public AbonOrder GetOne(int id)
        {
            return Database.GetOne(id);
        }

        public void Delete(AbonOrder abonOrder)
        {
            Database.Delete(abonOrder);
        }

        public void Update(AbonOrder abonOrder)
        {
            Database.Update(abonOrder);
        }
    }
}