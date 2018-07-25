using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FitnessCentreSite.Dal;
using FitnessCentreSite.Models;

namespace FitnessCentreSite.Service
{
    public class BannerService : IBannerService
    {
        IBannerDal Database { get; set; }

        public BannerService(IBannerDal d)
        {
            Database = d;
        }
        public void Delete(Banner banner)
        {
            Database.Delete(banner);
        }

        public void Create(Banner banner)
        {
            Database.Create(banner);
        }

        public IList<Banner> ListAll()
        {
            return Database.ListAll();
        }
    }
}