using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu2.Lib
{
    public class Insan
    {
        private string _ad, _soyad;
        private int _yas;
        private DateTime _dogumTarihi;
        private Cinsiyetler _cinsiyet;

        public string Ad
        {
            get { return _ad; }
            set { _ad = AdSoyadHazirla(value); }
        }
        public string Soyad
        {
            get { return _soyad; }
            set { _soyad = AdSoyadHazirla(value); }
        }
        public string TCKN { get; set; }
        public int Yas
        {
            get { return _yas; }
        }

        public DateTime DogumTarihi
        {
            get { return _dogumTarihi; }
            set
            {
                TimeSpan aralik = DateTime.Now - value;
                double yil = aralik.TotalDays / 365;
                _yas = (int)yil;
                if (yil > 17)
                {
                    _dogumTarihi = value;
                }
                else
                {
                    throw new Exception("Sisteme 18 yaşından gün almamış kişileri kaydedemiyoruz!");
                }
            }
        }
        public Cinsiyetler Cinsiyet { get; set; }

        #region Metodlar

        private string AdSoyadHazirla(string kelime)
        {
            foreach (char harf in kelime)
            {
                if (!(char.IsLetter(harf) || char.IsWhiteSpace(harf)))
                    throw new Exception("Ad veya Soyad içerisinde geçersiz karakter bulunmaktadır.");
            }
            if (kelime.Trim().Length < 3)
                throw new Exception("Ad veya Soyad en az 3 karakter olmalı");
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(kelime);
        }

        public Insan()
        {
            string imei = string.Empty;
            do
            {
                string guid = Guid.NewGuid().ToString().Replace("-", "");
                foreach (char item in guid)
                {
                    if (imei.Length == 11) break;
                    if (char.IsDigit(item))
                    {
                        imei += item;
                    }
                }
            } while (imei.Length != 11);
            TCKN = imei;
        }

        public override string ToString()
        {
            return $"{this.Ad} ";
        }

        #endregion
    }
    #region Enumlar
    public enum Cinsiyetler
    {
        Erkek,
        Kadın,
    }
    public enum DoktorBransı
    {
        BeyinCerrahı,
        KBB,
        Acil,
        CocukDoktoru,
        GenelCerrahi,
        Göz,
        Kalp,
        Psikoloji
    }
    public enum HemsireBransı
    {
        BeyinCerrahı,
        KBB,
        Acil,
        CocukDoktoru,
        GenelCerrahi,
        Göz,
        Kalp,
        Psikoloji
    }
    public enum Gorevler
    {
        Muhasebe,
        Temizlik,
        Güvenlik,
        Yemek
    } 
    #endregion
}
