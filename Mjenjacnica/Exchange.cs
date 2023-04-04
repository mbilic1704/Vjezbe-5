using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mjenjacnica
{
    public class Exchange
    {
       public ICurrencyConverter GetConverter(Currency from, Currency to)
        {
         
            if(from.Type== CurrencyType.Fiat && to.Type==CurrencyType.Fiat)
            {
                FiatConverter fiatConverter = new FiatConverter();
                return fiatConverter;
            }
            if(from.Type == CurrencyType.Crypto && to.Type == CurrencyType.Crypto)
            {
                CryptoConverter cryptoConverter = new CryptoConverter();
                return cryptoConverter;
            }
            else
            {
                throw new NotSupportedException();
            }
        }

        public double Convert(Currency from, Currency to, double amount)
        {
            ICurrencyConverter converter = GetConverter(from, to);
            double rez = converter.Convert(from, to, amount);

            return rez;
        }
    }
}
