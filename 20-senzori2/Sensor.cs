using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_senzori2
{
    public abstract class Sensor : ISensor
    {
        public string Identifier { get; set ; }

        public Sensor(string identifier)
        {
            
        }
        public abstract SensorData FetchData();
        
    }
}
