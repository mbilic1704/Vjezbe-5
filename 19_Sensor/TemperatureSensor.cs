using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Sensor
{
    public class TemperatureSensor : Sensor
    {
        public TemperatureSensor(string identifier, string unit) : base(identifier,unit)
        {
            
        }
        public override double GetCurrentValue()
        {
            double value;

            Random random = new Random();
            value = random.Next(10,20);

            return value;
        }
    }
}
