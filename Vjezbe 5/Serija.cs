using Streaming_platforma2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezbe_5
{
    public  class Serija: IVideoZapis
    {
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public KategorijaZapisa Kategorija{ get; set; }

        public List<Sezona> Sezone;

        public Serija(string naziv, string opis)
        {
            Naziv = naziv;
            Opis = opis;

            Sezone = new List<Sezona>();
        }

        public string Reproduciraj()
        {
            return ($"Započeta reprodukcija serije{Naziv}, sezone {Sezone[0].RedniBrojSezone}, epizoda {Sezone[0].Epizode[0].Naziv}");
        }
    }
}
