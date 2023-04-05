using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_mjerniUredaji
{
    public abstract class Meter
    {
        public string Name { get; set; }
        public string Unit { get; set; }
        public string RawData { get; set; }

        public Meter(string name, string unit, string rawData)
        {
            Name = name;
            Unit = unit;
            RawData = rawData;
        }

        public abstract double[] GetDailyData();

        public double CalculatedDailyAverage()
        {
            return GetDailyData().Average();
        }
    }
}
