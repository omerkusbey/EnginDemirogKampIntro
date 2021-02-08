using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç İçin Temel Kurs";
            string kurs3 = "Java";
            string kurs4 = "Python" ;

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            //array - dizi
            Console.WriteLine("---------------------------------------------------------");
            
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya başlangıç İçin Temel Kurs" , "Java", "Python", "Ömer","Kuşbey" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
           
            Console.WriteLine("for bitti");
         
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - footer");
        }
    }
}
