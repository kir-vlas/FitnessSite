using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate.Mapping.Attributes;

namespace FitnessCentreSite.Models
{
    public class Good
    {
        [Id(0, Name = "Id")]
        [Generator(1, Class = "native")]
        public virtual int Id { get; set; }

        [Property]
        public virtual string Name { get; set; }

        [Property]
        public virtual decimal Price { get; set; }

        [Property]
        public virtual string Description { get; set; }

        [ManyToOne(Name = "Category", Column = "Id", ClassType = typeof(Category), Cascade = "save-update")]
        public virtual Category Category { get; set; }

        [Property]
        public virtual byte[] Image { get; set; }
    }
}