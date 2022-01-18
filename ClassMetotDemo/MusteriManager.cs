using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Tebrikler. Yeni Müşteri Eklendi! : " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi);
        }

        public void Listele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("ID " + musteri.MusteriId + " : " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi);
            }
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Tebrikler. Silme İşlemi Başarı ile Gerçekleşti! : " + musteri.MusteriAdi + " " + musteri.MusteriSoyadi);
        }
    }
}
