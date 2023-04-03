using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezbe_5
{
    public class Sezona
    {
        public Serija Serija{ get; set; }
        public int RedniBrojSezone { get; set; }
        public List<Epizoda> Epizode { get; set; }

        public Sezona()
        {
            Epizode = new List<Epizoda>();
            
        }
    }
}
