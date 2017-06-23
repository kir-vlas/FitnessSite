using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessCentreSite.Models;

namespace FitnessCentreSite.Dal
{
    public interface IGoodDal
    {
        IList<Good> ListAll();

        void Add(Good good);

        void Delete(Good good);

        Good GetOne(int id);
    }
}
