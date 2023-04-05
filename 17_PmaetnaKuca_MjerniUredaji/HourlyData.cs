using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_PmaetnaKuca_MjerniUredaji
{
    public class HourlyData
    {
        public int Hour { get; set; }
        public double Value { get; set; }
        public HourlyData(int hour, double value)
        {
            Hour = hour;
            Value = value;
        }
    }
}
