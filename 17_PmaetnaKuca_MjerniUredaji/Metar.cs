using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_PmaetnaKuca_MjerniUredaji
{
    public abstract class Metar : IMetar
    {
        public string Name { get; set; }
        public string Unit { get ; set ; }
        public List<HourlyData> Data { get; set ; }

        public Metar(string name, string unit, string rawData)
        {
            Name = name;
            Unit = unit;
            rawData = Data.ToString();

            PopulateDailyData(rawData);
        }

        protected abstract void PopulateDailyData(string rawData);

    }
}
