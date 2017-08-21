using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyonu2.Lib
{
    public interface IMaas
    {
        //buraya ekleyeceğiniz property ve methodların erişim belirleyicileri yazılmaz!
        //buraya ekleyeceğiniz methodların içi de yazılmaz
        decimal Maas { get; set; }

        decimal MaasHesapla(int gun);
    }
}
