using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_mjerniUredaji
{
    public class ElectricityMeter : Meter
    {
        public ElectricityMeter(string name, string unit, string rawData) :base(name,unit,rawData)
        {
            
        }
        public override double[] GetDailyData()
        {
            string[] splitData = RawData.Split(';');

            double[] data = new double[24];

            for(int i = 0;i<=24; i++)
            {
                data[i] = double.Parse(splitData[i]);
            }

            return data;
        }
    }
}
