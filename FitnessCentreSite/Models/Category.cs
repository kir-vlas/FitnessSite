using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate.Mapping.Attributes;

namespace FitnessCentreSite.Models
{
    [Class]
    public class Category
    {
        [Id(0, Name = "Id")]
        [Generator(1, Class = "native")]
        public virtual int Id { get; set; }

        [Property]
        public virtual string CatTitle { get; set; }

        [Bag(0,Name = "Good", Inverse = true)]
        [Key(1, Column = "Id")]
        [OneToMany(2,ClassType = typeof(Good))]
        public virtual IList<Good> Good {
            get { return Good ?? (Good = new List<Good>()); }
            set { Good = value; }
        }
    }
}