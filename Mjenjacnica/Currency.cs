using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mjenjacnica
{
  
    public class Currency
    {
        public string Name { get; set; }
        public CurrencyType Type { get; set; }
        public double Rate { get; set; }
    }
}
