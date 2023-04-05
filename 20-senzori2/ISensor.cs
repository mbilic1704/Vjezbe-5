using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_senzori2
{
    public interface ISensor
    {
        string Identifier { get;set; }

        SensorData FetchData();
    }
}
