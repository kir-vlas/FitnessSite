using FitnessCentreSite.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FitnessCentreSite.Models;

namespace FitnessCentreSite.Service
{
    public class TranerService : ITranerService
    {
        ITranersDal Database { get; set; }

        public TranerService(TranersDal d)
        {
            Database = d;
        }

        public IList<Traner> ListAll()
        {
            return Database.ListAll();
        }

        public Traner GetTraner(int id)
        {
            return Database.GetTraner(id);
        }

        public void Save(Traner traner)
        {
            Database.Save(traner);
        }

        public void Delete(Traner traner)
        {
            Database.Delete(traner);
        }

        public void Update(Traner traner)
        {
            Database.Update(traner);
        }
    }
}