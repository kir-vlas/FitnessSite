using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessCentreSite.Models;

namespace FitnessCentreSite.Service
{
    public interface IGoodService
    {
        IList<Good> ListAll();

        void Add(Good good);

        void Delete(Good good);

        Good GetOne(int id);
    }
}
