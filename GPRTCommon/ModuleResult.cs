using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPRTCommon
{
    public class ModuleResult : Result
    {
        public Module Module { get; set; }
        public List<AssesmentResult> AssesmentResults { get; set; }
        public int Credits { get; set; }
        public decimal Mark { get; set; }
    }
}
