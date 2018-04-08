using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GPRTWeb.Models
{
    public class Level
    {
        [Key]
        public int Id { get; set; }
        public string LevelName { get; set; }
        public List<Module> Modules { get; set; }
    }
}