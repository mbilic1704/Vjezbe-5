using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pricuva
{
    public class Zgrada
    {
        public string OznakaZgrade { get; set; }

        public List<Zona> PopisZona { get; set; }

        public Zgrada()
        {
            PopisZona = new List<Zona>();
        }
    }
}
