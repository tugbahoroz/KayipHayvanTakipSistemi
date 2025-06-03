using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KayipHayvanTakipSistemi
{
    internal class Ilan
    {
        public Hayvan Hayvan { get; set; }
        public Sahip Sahip { get; set; }
        public string KayipTarihi { get; set; }
        public string Aciklama { get; set; }

        public Ilan(Hayvan hayvan, Sahip sahip, string tarih, string aciklama)
        {
            Hayvan = hayvan;
            Sahip = sahip;
            KayipTarihi = tarih;
            Aciklama = aciklama;
        }

        public override string ToString()
        {
            return $"{Hayvan}\nSahip: {Sahip}\nKayıp Tarihi: {KayipTarihi}\nAçıklama: {Aciklama}";
        }
    }
}
