using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencija_za_nekretnine
{
    public class Kat
    {
        public int BrojKata { get; set; }

        public List<IProstor> PopisProstora { get; set; }

        public Kat()
        {
            PopisProstora = new List<IProstor>();
        }
    }
}
