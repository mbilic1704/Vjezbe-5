using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_senzori2
{
    public static class UnitConverter
    {
        public static double ConvertFahrenheitToCelsius(double valueF)
        {
            double valueC = (5 / 9) * (valueF - 32);
            return valueC;
        }
    }
}
