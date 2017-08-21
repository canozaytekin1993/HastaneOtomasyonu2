using System.Collections.Generic;
using System.Linq;

namespace HastaneOtomasyonu2.Lib
{
    public class Personel : Insan,IMaas
    {
        private string _telefon;
        private decimal _maas;
        private Gorevler _gorev;

        public string Telefon { get => _telefon; set => _telefon = value; }
        public decimal Maas { get => _maas; set => _maas = value; }
        public Gorevler Gorev { get => _gorev; set => _gorev = value; }

        public decimal MaasHesapla(int gun)
        {
            return Maas * (gun / 30);
        }

        public static List<Personel> Ara(List<Personel> personeller, string kelime)
        {
            List<Personel> sonuclar = new List<Personel>();
            sonuclar = personeller.Where(item => item.Ad.ToLower().Contains(kelime.ToLower()) || item.Soyad.ToLower().Contains(kelime.ToLower()) || item.TCKN == kelime).ToList();
            return sonuclar;
        }

        public override string ToString()
        {
            return $"{this.Ad} {this.Soyad} - {this.TCKN} - {this.Cinsiyet} - {this.Gorev} - {this.Maas}";
        }
    }
}
