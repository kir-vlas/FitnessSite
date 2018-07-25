using FitnessCentreSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCentreSite.Service
{
    public interface ITranerService
    {
        IList<Traner> ListAll();

        Traner GetTraner(int id);

        void Save(Traner traner);

        void Delete(Traner traner);

        void Update(Traner traner);
    }
}
