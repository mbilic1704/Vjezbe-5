﻿using Streaming_platforma2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezbe_5
{
    public class Film:IVideoZapis
    {
        public string Naziv { get; set; }
        public string Opis { get; set; }

        public int Trajanje { get; set; }
        public KategorijaZapisa Kategorija { get; set; }

        public Film(string naziv, string opis, int trajanje)
        {
            Naziv = naziv;
            Opis = opis;
            Trajanje = trajanje;
        }
        public string Reproduciraj()
        {
            return ($"Započeta reprodukcija filma {Naziv}");
        }
    }
}
