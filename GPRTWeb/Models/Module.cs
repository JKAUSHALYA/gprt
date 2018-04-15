using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GPRTWeb.Models
{
    public class Module
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ModuleName { get; set; }
        public string PredictedMark { get; set; }
        public string ActualMark { get; set; }

        public Level Level { get; set; }
    }
}