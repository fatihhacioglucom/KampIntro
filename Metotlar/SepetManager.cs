using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {
        //Naming Convention - isimlendirme kuralı
        //Bir yerde normal bir parantez görürsek orada metot çalışıyor anlamına gelir.
        //syntax - yazım şekilleri
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi! : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyati, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete Eklendi!: " + urunAdi);
        }
    }
}
