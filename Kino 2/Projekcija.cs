using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kino_2
{
    public class Projekcija
    {
        public DateTime Vrijeme { get; set; }

        public Dvorana Dvorana { get; set; }
        public IPredstava Predstava { get; set; }
    }
}
