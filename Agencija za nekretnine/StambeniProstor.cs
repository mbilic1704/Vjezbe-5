using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencija_za_nekretnine
{
    public class StambeniProstor : IProstor
    {
        public string OznakaProstora { get ; set ; }
        public Kat Kat { get; set ; }
        public bool Dostupan { get;set; }

        public string Vlasnik { get; set; }

        public void Prodaj(string kupac)
        {
            Vlasnik = kupac;
            Dostupan = false;
        }
    }
}
