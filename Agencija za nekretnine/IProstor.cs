using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agencija_za_nekretnine
{
    public interface IProstor
    {
        string OznakaProstora { get; set; }
        Kat Kat { get; set; }
        bool Dostupan { get; set; }
        void Prodaj(string kupac);

    }
}
