using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FitnessCentreSite.Models;

namespace FitnessCentreSite.Service
{
    public interface IBannerService
    {
        void Delete(Banner banner);

        void Create(Banner banner);

        IList<Banner> ListAll();
    }
}