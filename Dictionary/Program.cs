using System;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> ogrenciler = new MyDictionary<int, string>();
            ogrenciler.Add(100, "Fatih Hacıoğlu");

            Console.WriteLine(ogrenciler);
        }
    }
}
