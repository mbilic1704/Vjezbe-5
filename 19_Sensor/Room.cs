using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Sensor
{
    public class Room
    {
        public string Name { get; set; }
        public List<Sensor> DeployedSensor { get; set; }

        public Room(string name)
        {
            Name = name;

            DeployedSensor = new List<Sensor>();    
        }

        public string ReportSensorData()
        {
            string returnMe = "";

            foreach(Sensor s in  DeployedSensor)
            {
               returnMe += "Current value for sensor" + s.Identifier + " is" + s.GetCurrentValue() + s.Unit + "\n ";
            }

            return returnMe;
        }
    }
}
