using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_PmaetnaKuca_MjerniUredaji
{
    public interface IMetar
    {
        string Name { get; set; }
        string Unit { get; set; }
        List<HourlyData> Data { get; set; }
    }
}
