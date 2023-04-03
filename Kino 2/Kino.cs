using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino_2
{
    public class Kino
    {
        public List<Dvorana> PopisDvorana { get; set; }
        public List<Projekcija> PopisProjekcija { get; set; }

        public List<Projekcija> DohvatiProjekcije(string naziv)
        {
            List<Projekcija> nadeneProjekcije = new List<Projekcija>();


            foreach(Projekcija p in PopisProjekcija)
            {
                if(p.Predstava.Naziv == naziv)
                {
                    nadeneProjekcije.Add(p);
                }
            }

            return nadeneProjekcije;
        }
    }
}
