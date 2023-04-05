using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Sensor
{
    public abstract class Sensor
    {
        public string Identifier { get; set; }
        public string Unit { get; set; }

        public Sensor(string identifier, string unit)
        {
            Identifier = identifier;
            Unit = unit;
        }

        public abstract double GetCurrentValue();

    }
}
