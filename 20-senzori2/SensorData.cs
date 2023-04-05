using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_senzori2
{
    public class SensorData
    {
        public DateTime TimeStamp { get; set; }
        public string Unit { get; set; }
        public double  Value { get; set; }

        public SensorData(string unit, double value)
        {
            Unit = unit;
            Value = value;
            TimeStamp = DateTime.Now;
        }
    }
}
