using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burza
{
    public class TradingAccount
    {
        public string AccountNo { get; set; }
        public List<Wallet> Wallets { get; set; }

        public TradingAccount(string accountNo)
        {
            AccountNo = accountNo;
            Wallets = new List<Wallet>();
        }

        public double CalculateTotalValue()
        {
            double total = 0;

            foreach(Wallet w in Wallets)
            {
                total += w.CalculateValue();
            }

            return total;
        }

    }
}
