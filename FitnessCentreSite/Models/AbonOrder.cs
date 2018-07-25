using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate.Mapping.Attributes;

namespace FitnessCentreSite.Models
{
    [Class]
    public class AbonOrder
    {
        [Id(0, Name = "Id")]
        [Generator(1, Class = "native")]
        public virtual int Id { get; set; }

        [Property]
        public virtual string Name { get; set; }

        [Property]
        public virtual string Phone { get; set; }
    }
}