using FitnessCentreSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCentreSite.Service
{
    public interface IAbonOrderService
    {
        void Save(AbonOrder abonOrder);
    }
}
