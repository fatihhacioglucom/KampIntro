using System;

namespace IkinciGunOdevAlti
{
    //Hepsiburada.com (Elektronik - Bilgisayar/Tablet - Dizüstü Bilgisayarlar) Kategorisi Ürün Listesi 
    class Product
    {
        public string ProductName { get; set; }
        public double FirsPrice { get; set; }
        public double LastPrice { get; set; }
        public int DiscountRate { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductName = "MSI GF63 THIN 11UD-428XTR";
            product1.FirsPrice = 20822;
            product1.LastPrice = 17699;
            product1.DiscountRate = 15;

            Product product2 = new Product();
            product2.ProductName = "Dell Gaming G15 5510";
            product2.FirsPrice = 17609;
            product2.LastPrice = 15799;
            product2.DiscountRate = 10;

            Product product3 = new Product();
            product3.ProductName = "HP Pavillion 13-BE0004NT";
            product3.FirsPrice = 12439;
            product3.LastPrice = 10999;
            product3.DiscountRate = 12;

            Product product4 = new Product();
            product4.ProductName = "Lenovo Ideapad L3 15ITL6";
            product4.FirsPrice = 4599;
            product4.LastPrice = 4399;
            product4.DiscountRate = 4;

            Product product5 = new Product();
            product5.ProductName = "Asus ROG Strix G513IC-HN029";
            product5.FirsPrice = 17599;
            product5.LastPrice = 15979;
            product5.DiscountRate = 9;

            Product[] products = new Product[] { product1, product2, product3, product4, product5 };

            Console.WriteLine("---------------------FOR DÖNGÜSÜ---------------------");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].ProductName + " : " + products[i].FirsPrice + "TL'den %" + products[i].DiscountRate + " indirimle " + products[i].LastPrice + " TL'ye düşmüştür.");
            }

            Console.WriteLine("---------------------FOREACH DÖNGÜSÜ---------------------");
            foreach (Product product in products)
            {
                Console.WriteLine(product.ProductName + " : " + product.FirsPrice + "TL'den %" + product.DiscountRate + " indirimle " + product.LastPrice + " TL'ye düşmüştür.");
            }

            Console.WriteLine("---------------------WHİLE DÖNGÜSÜ---------------------");
            int sayac = 0;
            while (sayac < products.Length)
            {
                Console.WriteLine(products[sayac].ProductName + " : " + products[sayac].FirsPrice + "TL'den %" + products[sayac].DiscountRate + " indirimle " + products[sayac].LastPrice + " TL'ye düşmüştür.");
                sayac++;
            }
        }
    }
}
