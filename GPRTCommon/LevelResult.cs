using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPRTCommon
{
    public class LevelResult : Result
    {
        public Level Level { get; set; }
        public List<ModuleResult> ModuleResults { get; set; }
        public int TotalCredits { get; set; }
    }
}
