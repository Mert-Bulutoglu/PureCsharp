using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureCsharp
{
    internal class Arrays
    {
        static void Array()
        {
            Console.WriteLine("Lütfen dizi eleman sayısını veriniz :");
            int girilenDeger = Convert.ToInt32(Console.ReadLine());


            int[] values = new int[girilenDeger];


            Console.WriteLine("Diziyi oluşturdunuz, şimdi gerekli verilerle doldurun:");

            for (int i = 0; i < values.Length; i++)
            {
                values[i] = Convert.ToInt32(Console.ReadLine());
            }

            int toplam = 0;

            for (int i = 0; i < values.Length; i++)
            {
                toplam += values[i];
            }

            Console.Write("Toplam değer: ");
            Console.WriteLine(toplam);

            Console.Write("Ortalama değer: ");
            Console.WriteLine(toplam / values.Length);
        }
        static void ArrayWithRandom()
        {




            Random randm = new Random();


            int[] nums = new int[20];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = randm.Next(1, 10);

                Console.Write(nums[i] + ",");
            }


            int howManyInt = 0;
            foreach (var item in nums)
            {
                if (item == 4)
                {
                    howManyInt++;
                }
            }

            Console.WriteLine("Dizi içerisinde 4 değeri {0} adettir.", howManyInt);






        }

    }
}
