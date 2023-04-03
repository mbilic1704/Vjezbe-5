using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pricuva
{
    public class StambenaZgrada : Zona
    {
        public override double IzracunajPricuvu()
        {
            double povrsina = 0;
            double pricuva;

            foreach(Prostor p in PopisProstora)
            {
                povrsina += p.PovrsinaProstora;
            }

            pricuva = povrsina * 2;
            return pricuva;
        }
    }
}
