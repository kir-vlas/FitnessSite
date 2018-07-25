using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FitnessCentreSite.Dal;
using FitnessCentreSite.Models;

namespace FitnessCentreSite.Service
{
    public class CategoryService : ICategoryService
    {
        ICategoryDal Database { get; set; }

        public CategoryService(ICategoryDal d)
        {
            Database = d;
        }

        public IList<Category> ListAll()
        {
            return Database.ListAll();
        }

        public void Delete(Category category)
        {
            Database.Delete(category);
        }

        public void Add(Category category)
        {
            Database.Add(category);
        }
    }
}