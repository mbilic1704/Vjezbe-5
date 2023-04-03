using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencija_za_nekretnine
{
    public class Agencija
    {
        public string Naziv { get; set; }

        public List<Zgrada> PopisZgrada{ get; set; }

        public Agencija()
        {
            PopisZgrada = new List<Zgrada>();
        }

        public void ProdajProstor(string oznakaProstora, string kupac)
        {
            foreach(Zgrada z in PopisZgrada)
            {
                foreach(Kat k in z.PopisKatova)
                {
                    foreach(IProstor p in k.PopisProstora)
                    {
                        if(p.OznakaProstora == oznakaProstora && p.Dostupan == true)
                        {
                            p.Prodaj(kupac);
                        }
                    }
                }
            }
        }
    }
}
