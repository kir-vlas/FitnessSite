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
    }
}