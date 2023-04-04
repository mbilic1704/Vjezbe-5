using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mjenjacnica
{
    public class CryptoConverter : ICurrencyConverter
    {
        public double Convert(Currency from, Currency to, double amount)
        {
            double rez = (from.Rate / to.Rate) * amount * 0.95;
            return rez;
        }
    }
}
