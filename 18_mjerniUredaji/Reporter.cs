using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_mjerniUredaji
{
    public class Reporter
    {
        public string CreateDailyAverageReport(Meter meter)
        {
            double rez = meter.CalculatedDailyAverage();
            string line = "Daily average value is" + rez + "kWh.";

            return line;
        }
    }
}
