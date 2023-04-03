using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencija_za_nekretnine
{
    public class Zgrada
    {
        public string OznakaZgrade { get; set; }

        public List<Kat> PopisKatova { get; set; }

        public Zgrada()
        {
            PopisKatova = new List<Kat>();
        }
    }
}
