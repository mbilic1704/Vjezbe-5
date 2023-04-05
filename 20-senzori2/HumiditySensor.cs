using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_senzori2
{
    public class HumiditySensor : Sensor
    {
        public HumiditySensor(string identifier) : base(identifier)
        {

        }

        public override SensorData FetchData()
        {
            Random r = new Random();
            SensorData newSensor = new SensorData("F", r.Next());

            return newSensor;
        }
    }
}
