using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradjevina
{
    public class VanjskiProstor : Prostor
    {
        public bool Natkriven { get; set; }

        public VanjskiProstor(string oznaka, double povrsina, bool natkriven) : base(oznaka,povrsina)
        {
            
        }
        public override double IzracunajNetoPovrsinu()
        {
            double netoPovrsina = 0;

            if(Natkriven==true) 
            {
                netoPovrsina = Povrsina * 0.5;
            }
            else
            {
                netoPovrsina = Povrsina * 0.3;
            }

            return netoPovrsina;
        }
    }
}
