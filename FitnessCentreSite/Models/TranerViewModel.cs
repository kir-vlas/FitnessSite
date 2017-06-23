using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FitnessCentreSite.Models
{
    public class TranerViewModel
    {
        [Required]
        [Display(Name = "Имя тренера")]
        public string Name { get; set; }


        [Required]
        [Display(Name = "Описание")]
        public string Description { get; set; }
    }
}