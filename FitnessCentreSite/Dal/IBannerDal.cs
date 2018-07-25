using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessCentreSite.Models;

namespace FitnessCentreSite.Dal
{
    public interface IBannerDal
    {
        void Delete(Banner banner);

        void Create(Banner banner);

        IList<Banner> ListAll();
    }
}
