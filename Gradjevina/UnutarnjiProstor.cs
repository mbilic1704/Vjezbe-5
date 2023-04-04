using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradjevina
{
    public class UnutarnjiProstor : Prostor
    {
        public UnutarnjiProstor(string oznaka, double povrsina) :base(oznaka,povrsina)
        {
            Oznaka = oznaka;
            Povrsina = povrsina;
        }
        public override double IzracunajNetoPovrsinu()
        {
            return Povrsina;
        }
    }
}
