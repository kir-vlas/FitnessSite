using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessCentreSite.Models;

namespace FitnessCentreSite.Dal
{
    public interface ICategoryDal
    {
        IList<Category> ListAll();

        void Delete(Category category);

        void Add(Category category);
    }
}
