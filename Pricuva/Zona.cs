using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pricuva
{
    public abstract class Zona
    {
        public string NazivZone { get; set; }

        public List<Prostor> PopisProstora { get; set; }

        public Zona()
        {
            PopisProstora = new List<Prostor>();
        }

        public abstract double IzracunajPricuvu();
        

       
    }
}
