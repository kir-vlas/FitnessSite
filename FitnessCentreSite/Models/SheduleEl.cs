using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FitnessCentreSite.Models
{
    public class SheduleEl
    {
        public enum Days { Monday, Tuesday, Wednesday, Thursday, Friday }

        public int TraningId { get; set; }

        public string Name { get; set; }

        public Days Day { get; set; }
    }
}