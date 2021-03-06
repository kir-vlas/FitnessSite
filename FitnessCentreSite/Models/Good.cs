﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NHibernate.Mapping.Attributes;

namespace FitnessCentreSite.Models
{
    [Class]
    public class Good
    {
        public int GoodId { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public int Category { get; set; }

        public byte[] Image { get; set; }

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