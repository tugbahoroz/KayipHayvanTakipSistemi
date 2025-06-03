using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KayipHayvanTakipSistemi
{
    internal class Sahip
    {
        public string Isim { get; set; }
        public string Telefon { get; set; }

        public Sahip(string isim, string telefon)
        {
            Isim = isim;
            Telefon = telefon;
        }

        public override string ToString()
        {
            return $"{Isim} - {Telefon}";
        }
    }
}
