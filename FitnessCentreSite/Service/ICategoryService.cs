using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessCentreSite.Models;

namespace FitnessCentreSite.Service
{
    public interface ICategoryService
    {
        IList<Category> ListAll();

        void Delete(Category category);

        void Add(Category category);
    }
}
