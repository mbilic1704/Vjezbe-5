using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradjevina
{
    public abstract class Prostor : IProstor
    {
        public string Oznaka { get ; set ; }
        public double Povrsina { get; set ; }

        public Prostor(string oznaka, double povrsina)
        {
            Oznaka = oznaka;
           Povrsina = povrsina; 
        }

        public abstract double IzracunajNetoPovrsinu();
        
    }
}
