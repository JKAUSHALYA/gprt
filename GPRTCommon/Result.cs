using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPRTCommon
{
    public class Result
    {
        public enum Status { PASS, FAIL}
        public Status ResultStatus { get; set; }
    }
}
