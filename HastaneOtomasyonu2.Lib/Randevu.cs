using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu2.Lib
{
    public class Randevu
    {
        private Doktor _doktor;
        private Hasta _hasta;
        private string _saat = "";

        public Doktor Doktor { get => _doktor; set => _doktor = value; }
        public Hasta Hasta { get => _hasta; set => _hasta = value; }
        public string Saat { get => _saat; set => _saat = value; }
    }
}
