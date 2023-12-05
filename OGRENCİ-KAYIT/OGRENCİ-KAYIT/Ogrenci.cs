using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGRENCİ_KAYIT
{
    internal class Ogrenci
    {
        int numara;
        string adsoyad;
        string sinif;
        string cinsiyet;
        string telefon;
         

        public int Numara { get => numara; set => numara = value; }
        public string Adsoyad { get => adsoyad; set => adsoyad = value; }
        public string Sinif { get => sinif; set => sinif = value; }
        public string Cinsiyet { get => cinsiyet; set => cinsiyet = value; }
        public string Telefon { get => telefon; set => telefon = value; }

        public Ogrenci(int numara, string adsoyad, string sinif, string cinsiyet, string telefon)
        {
            this.numara = numara;
            this.adsoyad = adsoyad;
            this.sinif = sinif;
            this.cinsiyet = cinsiyet;
            this.telefon = telefon;
        }
    }



}
