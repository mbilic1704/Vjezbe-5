using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otvaranje_prozora
{
    public interface IOtvor
    {
        string Oznaka { get; set; }
        StatusOtvora Status { get; set; }

        void Otvori();
        void Zatvori();
    }
}
