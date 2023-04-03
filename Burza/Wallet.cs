using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burza
{
    public abstract class Wallet
    {
        public double Amount { get; set; }
        public string Currency { get; set; }

        public Wallet(double amount, string currency)
        {
            this.Amount = amount;
            this.Currency = currency;
        }

        protected abstract double GetRateInHRK();

        public double CalculateValue()
        {
            double value = Amount * GetRateInHRK();
            return value;
        }
    }
}
