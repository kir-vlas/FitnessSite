using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FitnessCentreSite.Models;

namespace FitnessCentreSite.Dal
{
    public interface IAbonOrdersDal
    {
        void Save(AbonOrder abonOrder);
        
    }
}