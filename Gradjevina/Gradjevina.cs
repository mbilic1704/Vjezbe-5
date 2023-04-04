using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradjevina
{
    public class Gradjevina
    {
        public string Naziv { get; set; }

        public List<Prostor> PopisProstora { get; set; }

        public Gradjevina(string naziv)
        {
            Naziv = naziv;

            PopisProstora = new List<Prostor>();
        }

        public double IzracunajNetoPovrsinu()
        {
            double ukupnanNetoPovrsina = 0;

            foreach(Prostor p in PopisProstora)
            {
                ukupnanNetoPovrsina += p.IzracunajNetoPovrsinu();
            }

            return ukupnanNetoPovrsina;
        }
    }
}
