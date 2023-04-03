using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pricuva
{
    public class NestambenaZona : Zona
    {
        public override double IzracunajPricuvu()
        {
            double povrsina = 0;
            double pricuva;

            foreach (Prostor p in PopisProstora)
            {
                povrsina += p.PovrsinaProstora;
            }

            pricuva = povrsina * 3;
            return pricuva;
        }
    }
}
