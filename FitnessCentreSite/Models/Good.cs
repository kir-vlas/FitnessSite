using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitnessCentreSite.Models
{
    public class Good
    {
        public int GoodId { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public int Category { get; set; }

        public byte[] Image { get; set; }
    }
}