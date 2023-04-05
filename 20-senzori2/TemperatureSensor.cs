using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_senzori2
{
    public class TemperatureSensor : Sensor
    {
        public TemperatureSensor(string identifier):base(identifier)
        {
            
        }
        public override SensorData FetchData()
        {
            Random r = new Random();
            double valueF = r.Next(32, 100);

            double valueC = UnitConverter.ConvertFahrenheitToCelsius(valueF);

            SensorData newSensor = new SensorData("F", valueC);

            return newSensor;
        }
    }
}
