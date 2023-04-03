using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino_1
{
    public class Blagajna
    {
        public List<Karta> ProdaneKarte { get; set; }

        public Blagajna()
        {
            ProdaneKarte = new List<Karta>();
        }
        public void ProdajKartu(Projekcija projekcija, Sjedalo sjedalo)
        {
            
            Karta kupljenaKarta = new Karta(projekcija, sjedalo);
            
            foreach(Karta k in ProdaneKarte)
            {
                if(k.Projekcija == projekcija || k.Sjedalo == sjedalo)
                {
                    Console.WriteLine("Nije moguće kupiti kartu.");
                }
                else
                {
                    ProdaneKarte.Add(kupljenaKarta);
                }
            }
       
            
        }
    }
}
