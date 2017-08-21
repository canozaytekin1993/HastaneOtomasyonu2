using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu2.Lib
{
    public static class HemsireGetir
    {
        public static List<Hemsire> hemsireSecimi(List<Hemsire> hemsire, string brans)
        {
            //List<Hemsire> bosHemsireler = hemsire.Where(x => Convert.ToString(x.HemsireBransı) == brans).ToList();
            //return bosHemsireler;

            List<Hemsire> bosHemsireler = hemsire.Where(x => Convert.ToString(x.HemsireBransı) == brans).ToList();
            return bosHemsireler;
        }
    }
}
