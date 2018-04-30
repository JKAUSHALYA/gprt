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
        public string Title { get; set; }
        public string Code { get; set; }
        public string CreditValue { get; set; }
        public List<Assesment> Assesments { get; set; }

        public Level Level { get; set; }
    }
}