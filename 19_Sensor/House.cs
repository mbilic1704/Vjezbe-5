using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Sensor
{
    public class House
    {
        public List<Room> Rooms { get; set; }

        public House()
        {
            Rooms = new List<Room>();
        }

        public string ReportSensorData()
        {
            foreach (Room r in Rooms)
            {
                return r.ReportSensorData() + "-----------" + "\n";
            }

            return null;
        }
    }
}
