using System;

namespace Classİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin" ;
            int yas = 35 ;

            Kurs kurs1 = new Kurs() ;
            kurs1.KursAdi = "C#";
            kurs1.Egitmeni = "Ömer Kuşbey";
            kurs1.IzlenmeOrani = 293;


            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmeni = "Ömer Kuşbey";
            kurs2.IzlenmeOrani = 93;
            

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Pyhton";
            kurs3.Egitmeni = "Ömer Kuşbey";
            kurs3.IzlenmeOrani = 793;

            // Console.WriteLine(kurs1.KursAdi + ":" + kurs1.Egitmeni + " " + kurs1.IzlenmeOrani);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ":" + kurs.Egitmeni + ":" + kurs.IzlenmeOrani);
            }
        }
    }
    
    class Kurs
    { // prop
        public string KursAdi { get; set; }
        public string Egitmeni { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
