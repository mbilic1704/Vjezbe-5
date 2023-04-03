using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino_1
{
    public class Karta
    {
        public Projekcija Projekcija { get; set; }
        public Sjedalo Sjedalo { get; set; }

        public Karta(Projekcija projekcija, Sjedalo sjedalo)
        {
            Projekcija = projekcija;
            Sjedalo = sjedalo;
        }

        public double OdrediCijenu()
        {
            double cijena = 0;

            if(Projekcija.Premijera == true)
            {
                cijena = 60;
            }
            else
            {
                cijena = 40;
            }

            return cijena;
        }
    }
}
