using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GPRTWeb.Models
{
    public class Assesment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string PredictedMark { get; set; }
        public string ActualMark { get; set; }
        public string Wheight { get; set; }

        public Module Module { get; set; }
    }
}