using System;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 1;
            musteri1.MusteriAdi = "Fatih";
            musteri1.MusteriSoyadi = "Hacıoğlu";
            musteri1.MusteriTcKimlik = "11111111111";
            musteri1.MusteriTelefonNo = "05322222222";
            musteri1.MusteriEposta = "fatihhacioglu@gmail.com";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 2;
            musteri2.MusteriAdi = "Buse";
            musteri2.MusteriSoyadi = "Ayvaz Hacıoğlu";
            musteri2.MusteriTcKimlik = "22222222222";
            musteri2.MusteriTelefonNo = "05333333333";
            musteri2.MusteriEposta = "buseayvazhacioglu@gmail.com";

            Musteri musteri3 = new Musteri();
            musteri3.MusteriId = 3;
            musteri3.MusteriAdi = "Arif";
            musteri3.MusteriSoyadi = "Ayvaz";
            musteri3.MusteriTcKimlik = "33333333333";
            musteri3.MusteriTelefonNo = "05344444444";
            musteri3.MusteriEposta = "arifayvaz@gmail.com";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            musteriManager.Listele(musteriler);

        }
    }
}
