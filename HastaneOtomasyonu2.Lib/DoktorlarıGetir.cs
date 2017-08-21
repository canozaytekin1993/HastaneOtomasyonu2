using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu2.Lib
{
    public static class DoktorlarıGetir
    {
        public static List<Doktor> DoktorSecimi(List<Doktor> doktor, string brans)
        {
            List<Doktor> Doktorisimleri = doktor.Where(x => Convert.ToString(x.DoktorBransı) == brans).ToList();
            return Doktorisimleri;
        }
    }
}
