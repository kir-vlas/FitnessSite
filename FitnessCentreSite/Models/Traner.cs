using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitnessCentreSite.Models
{
    public class Traner
    {
        public int TranerId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
=======
using NHibernate.Mapping.Attributes;

namespace FitnessCentreSite.Models
{
    [Class]
    public class Traner
    {
        [Id(0, Name = "Id")]
        [Generator(1, Class = "native")]
        public virtual int Id { get; set; }

        [Property]
        public virtual string Name { get; set; }

        [Property]
        public virtual string Description { get; set; }

        [Property]
        public virtual byte[] Image { get; set; }
    }
}