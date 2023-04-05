using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_mjerniUredaji
{
    public class SmartHomeSystem
    {
        public List<Meter> Meters { get; set; }
        public Reporter Reporter { get; set; }

        public SmartHomeSystem()
        {
            Meters = new List<Meter>();
        }
    }
}
