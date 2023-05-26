using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureCsharp
{
    public class CleanSolutions
    {

        private decimal ortalamaHesap(decimal puan1, decimal puan2, decimal puan3)
        {
            decimal ortalama = (puan1 / 5) + (puan2 / 5) + (puan3 * 3) / 5;

            return ortalama;

        }

        public void girisPanelHazirla()
        {
            Console.WriteLine("Öğrenci not sistemine hoş geldiniz.");
            Console.WriteLine("Öğrenci ortalaması 0-45 arası kaldı.");
            Console.WriteLine("Öğrenci ortalaması 45-100 arası ise geçti.");

        }

        public void ogrenciNotHesapla(string name, string surname, decimal not1, decimal not2 , decimal not3 = 45)
        {
            Console.WriteLine("Öğrencinin bilgileri aşağıdaki gibidir");
            Console.WriteLine("Ad Soyad : {0} {1}", name, surname);
            decimal ortalama = ortalamaHesap(not1, not2, not3);
            ortalamaNotDegerlendir(ortalama);
        }

         void ortalamaNotDegerlendir(decimal ortalama)
        {
            if (ortalama >= 0 && ortalama < 45)
            {
                Console.WriteLine("Öğrenci {0} ortalamayla sınıfta kaldı", ortalama);

            }
            else
            {
                Console.WriteLine("Öğrenci {0} ortalamayla sınıfı geçti", ortalama);
            }
        }

        
    }
}
