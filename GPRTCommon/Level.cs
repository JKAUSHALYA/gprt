using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPRTCommon
{
    public class Level
    {
        public Level(string levelName)
        {
            this.LevelName = levelName;
        }

        public string LevelName { get; set; }
        public List<Module> Modules { get; set; }
    }
}
