using System;

namespace Kampİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //tytpe safety- tip güvenliği //do not repeat yourself //değer tutucu

            string kategoriEtiketi = "Kategoriler";
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;


            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Oku");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Oku");
            }
            else
            {
                Console.WriteLine("Eşittir Butonu");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

        }
    }
}
