using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pricuva
{
    public class Upravitelj
    {
        public List<Zgrada> PopisZgrada { get; set; }

        public Upravitelj()
        {
            PopisZgrada = new List<Zgrada>();

        }

        public double IzracunajBudzet(Zgrada zgrada)
        {
            double rez =0;

            foreach(Zona z in zgrada.PopisZona)
            {
                rez += z.IzracunajPricuvu();
            }

            return rez;
        }
    }
}
