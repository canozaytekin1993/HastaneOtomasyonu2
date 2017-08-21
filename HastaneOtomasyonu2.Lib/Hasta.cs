using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu2.Lib
{
    public class Hasta : Insan
    {
        private string _telefon;
        public string Telefon { get => _telefon; set => _telefon = value; }
        public string Saat { get; set; } = "";
        public static List<Hasta> Ara(List<Hasta> hastalar, string kelime)
        {
            List<Hasta> sonuclar = new List<Hasta>();
            sonuclar = hastalar.Where(item => item.Ad.ToLower().Contains(kelime.ToLower()) || item.Soyad.ToLower().Contains(kelime.ToLower()) || item.TCKN == kelime).ToList();
            return sonuclar;
        }

        public override string ToString()
        {
            return $"{this.Ad} {this.Soyad} - {this.TCKN} - {this.Cinsiyet}";
        }
    }
}
