using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu2.Lib
{
    public class Hemsire : Insan,IMaas
    {
        
        private decimal _maas;
        private string _telefon;
        public string Telefon { get => _telefon; set => _telefon = value; }
        public decimal Maas { get => _maas; set => _maas = value; }
        public HemsireBransı HemsireBransı { get; set; }
        public bool atanmısMı { get; set; } = false;

        public decimal MaasHesapla(int gun)
        {
            return Maas * (gun / 30);
        }

        public static List<Hemsire> Ara(List<Hemsire> Hemsireler, string kelime)
        {
            List<Hemsire> sonuclar = new List<Hemsire>();
            sonuclar = Hemsireler.Where(item => item.Ad.ToLower().Contains(kelime.ToLower()) || item.Soyad.ToLower().Contains(kelime.ToLower()) || item.TCKN == kelime).ToList();
            return sonuclar;
        }

        public override string ToString()
        {
            return $"{this.Ad} {this.Soyad} - {this.TCKN} - {this.Cinsiyet} - {this.HemsireBransı} - {this.Maas}";
        }
    }
}
