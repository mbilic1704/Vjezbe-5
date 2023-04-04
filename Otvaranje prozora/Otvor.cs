using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otvaranje_prozora
{
    public abstract class Otvor : IOtvor
    {
        public string Oznaka { get ; set ; }
        public StatusOtvora Status { get ; set ; }

        public Otvor(string oznaka) 
        {
            Oznaka = oznaka;
        }

        public abstract void Otvori();
        

        public void Zatvori()
        {
            Status = StatusOtvora.Zatvoren;
        }
    }
}
