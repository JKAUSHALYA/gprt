using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPRTCommon
{
    public class Module
    {
        public string Title { get; set; }
        public string Code { get; set; }
        public string CreditValue { get; set; }
        public List<Assesment> Assesments { get; set; }
    }
}
