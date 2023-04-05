using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_PmaetnaKuca_MjerniUredaji
{
    public class WaterMeter : Metar
    {
        public WaterMeter(string name, string unit, string rawData):base(name,unit,rawData)
        {
            
        }

        protected override void PopulateDailyData(string rawData)
        {
            Data = new List<HourlyData>();

            string[] splitData = rawData.Split(';');

            for (int i = 0; i <= 24; i++)
            {
                Data.Add(new HourlyData(i, double.Parse(splitData[i])/1000));
            }
        }
    }
}
