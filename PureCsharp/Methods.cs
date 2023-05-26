using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureCsharp
{
    public class Methods
    {
         
        /* Params */
        static void Topla(params int[] nums)
        {
            //Topla(1,2,3,4,5,6,30,45) şeklinde çağırılıp kullanılabilir
            int toplam = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                toplam += nums[i];
            }
        }

        /* Ref */
        static void Ref(ref int gelenDeger )
        {
            /* int sayi1 = 0;
             * Ref(ref sayi1);
             * Buranın sonucunda sayi1 e 10 değeri referans edilir */
            gelenDeger = 10;
        }

    }
}
