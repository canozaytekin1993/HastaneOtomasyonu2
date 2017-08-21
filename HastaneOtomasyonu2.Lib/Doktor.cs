using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu2.Lib
{
    public class Doktor:Insan,IMaas
    {
        private string _telefon;
        private decimal _maas;

        public string Saat { get; set; } = "";
        public string Telefon { get => _telefon; set => _telefon = value; }
        public decimal Maas { get => _maas; set => _maas = value; }
        public DoktorBransı DoktorBransı  { get; set; }

        public decimal MaasHesapla(int gun)
        {
            return Maas * (gun / 30);
        }

        public static List<Doktor> Ara(List<Doktor> doktorlar, string kelime)
        {
            List<Doktor> sonuclar = new List<Doktor>();
            sonuclar = doktorlar.Where(item => item.Ad.ToLower().Contains(kelime.ToLower()) || item.Soyad.ToLower().Contains(kelime.ToLower()) || item.TCKN == kelime).ToList();
            return sonuclar;
        }

        public List<Hemsire> hemsiresi { get; set; } = new List<Hemsire>();

        public override string ToString()
        {
            return $"{this.Ad} {this.Soyad} - {this.TCKN} - {this.Cinsiyet} - {this.DoktorBransı} - {this.Maas}";
        }
    }
}
