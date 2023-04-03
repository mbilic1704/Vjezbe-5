using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burza
{
    public class CryptoWallet : Wallet
    {
        public CryptoWallet(double amount, string currency) : base(amount, currency)
        {
            Amount = amount;
            Currency = currency;
        }
        protected override double GetRateInHRK()
        {
            return ExchangeAPI.GetCryptoRateInHRK(Currency);
        }
    }
}
