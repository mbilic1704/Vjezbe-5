using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otvaranje_prozora
{
    public class ElektronickiUpravljac
    {
        public List<Otvor> Otvori { get; set; }

        public void OtvoriOtvor (string oznakaOtvora)
        {
            foreach(Otvor o in Otvori)
            {
                if (o.Oznaka == oznakaOtvora && o.Status == StatusOtvora.Zatvoren)
                {
                    o.Status = StatusOtvora.Otvoren;
                }
            }
        }

        public void ZatvoriOtvor()
        {
            foreach (Otvor o in Otvori)
            {
               o.Status = StatusOtvora.Zatvoren;
                
            }

        }

        public void ZatvoriSve(string oznakaOtvora)
        {
            foreach(Otvor o in Otvori)
            {
                if(o.Oznaka == oznakaOtvora)
                {
                    o.Status = StatusOtvora.Zatvoren;
                }
            }
        }
           

    }
}
