using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino_1
{
    public class Projekcija
    {
        public DateTime VrijemeProjekcije { get; set; }
        public Dvorana Dvorana { get; set; }

        public Film Film { get; set; }

        public bool Premijera { get; set; }
    }
}
