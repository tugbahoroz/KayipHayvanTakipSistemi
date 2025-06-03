using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KayipHayvanTakipSistemi
{
    internal class Hayvan
    {
        public string Ad { get; set; }
        public string Tur { get; set; }
        public string Cins { get; set; }
        public int Yas { get; set; }

        public Hayvan(string ad, string tur, string cins, int yas)
        {
            Ad = ad;
            Tur = tur;
            Cins = cins;
            Yas = yas;
        }

        public override string ToString()
        {
            return $"{Ad} ({Tur} - {Cins}, {Yas} yaşında)";
        }
    }
}
