using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otvaranje_prozora
{
    public class Vrata : Otvor
    {
        public bool Zakljucano { get; set; }

        public Vrata(string oznaka, bool zakljucano) : base(oznaka)
        {
            Oznaka = oznaka;
            Zakljucano = zakljucano;
        }
        public override void Otvori()
        {
            if(Zakljucano == false)
            {
                Status = StatusOtvora.Otvoren;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
    }
}
