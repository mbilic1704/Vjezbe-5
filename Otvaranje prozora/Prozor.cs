using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otvaranje_prozora
{
    public class Prozor : Otvor
    {
        public Prozor(string oznaka):base(oznaka)
        {
            Oznaka = oznaka;
        }
        public override void Otvori()
        {
            Status = StatusOtvora.Otvoren;
        }
    }
}
