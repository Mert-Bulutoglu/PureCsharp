using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureCsharp
{
    internal class Collections
    {
        static void deleteObjectInArrayList()
        {

            ArrayList A1 = new ArrayList();

            A1.Add("Mert");
            A1.Add("Bulutoğlu");
            A1.Add("test");
            A1.Add(234);

            #region Delete object in ArrayList

            //A1.Remove("test");

            //A1.RemoveRange(2, 2); // 2. indexten sonra 2 değer siler

            //A1.RemoveAt(3); // 3. indexteki değeri siler


            A1.Remove(234);


            #endregion

        }
        static void sortedArrayList()
        {

            #region Sorted ArrayLists

            ArrayList A1 = new ArrayList();

            A1.Add("Mert");
            A1.Add("Bulutoğlu");
            A1.Add("test");
            A1.Add(234);

            //A1.Reverse(); // change direction of array list

            A1.Sort(); // Sorts only string values, A to Z , if there is any int value into array list, program returns error.

            #endregion

        }
        static void helpersForArrayList()
        {
            ArrayList A1 = new ArrayList();

            A1.Add("Mert");
            A1.Add("Bulutoğlu");
            A1.Add("test");
            A1.Add(234);


            #region Helpers of Arrays


            //bool control1 = A1.Contains("Mert");  //böyle bir değer array de var mı?

            //if (A1.Contains("Mert"))
            //{
            //    int indexValue = A1.IndexOf("Mert"); // "Mert" kaçıncı indexte bunu gösterir.
            //    A1.RemoveAt(indexValue);
            //}

            //A1.Clear(); // tüm array değerleri siler
            //A1.TrimToSize(); //koleksiyonun geride kalan size ını sıfırlar.

            #endregion

        }
        static void practiceOfLotsOfLogics()
        {

            string secilen = "";

            ArrayList degerListesi = new ArrayList();


            do
            {
                Console.Clear();
                Console.WriteLine("Menü");
                Console.WriteLine("1 - Değer Ekle");
                Console.WriteLine("2 - Değer Listele");
                Console.WriteLine("3 - Değer Ara");
                Console.WriteLine("4 - Değer Düzenle");
                Console.WriteLine("5 - Değer Sil");
                Console.WriteLine("6 - Uygulama çıkış");
                Console.Write("Seçiniz: ");
                secilen = Console.ReadLine();

                switch (secilen)
                {
                    case "1":
                        Console.Write("Eklemek istediğiniz değeri giriniz: ");
                        string girilenDeger1 = Console.ReadLine();
                        degerListesi.Add(girilenDeger1);
                        Console.WriteLine("Değer başarıyla eklenildi. ");
                        System.Threading.Thread.Sleep(1000);
                        break;
                    case "2":
                        for (int i = 0; i < degerListesi.Count; i++)
                        {
                            Console.WriteLine("{0}. Değer = {1}", i, degerListesi[i]);
                        }
                        Console.WriteLine("Devam etmek için bir tuşa basınız");
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.Write("Aramak istediğiniz değeri giriniz: ");
                        string girilenDeger2 = Console.ReadLine();
                        if (!degerListesi.Contains(girilenDeger2))
                        {
                            Console.WriteLine("Girdiğiniz {0} nesnesi arraylist de bulunamadı.", girilenDeger2);
                            Console.WriteLine("Fakat bu değeri listeye ekleyelim mi ?, Evet veya Hayır yazmanız yeterli ");
                            string secimYapılan = Console.ReadLine();

                            if (secimYapılan == "Evet")
                            {
                                degerListesi.Add(girilenDeger2);
                                Console.WriteLine("{0} başarıyla listeye eklendi.", girilenDeger2);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Girdiğiniz {0} nesnesi arraylist de {1}. indexte bulundu!.", girilenDeger2, degerListesi.IndexOf(girilenDeger2));
                        }

                        Console.WriteLine("Devam etmek için bir tuşa basınız");
                        Console.ReadLine();
                        break;
                    case "4":

                        Console.Write("Güncellemek istediğiniz değeri giriniz:  ");
                        string kullaniciGelenDeger = Console.ReadLine();

                        Console.WriteLine("{0} değerini hangi değer ile güncellemek istiyorsunuz: ", kullaniciGelenDeger);

                        foreach (var item in degerListesi)
                        {
                            Console.WriteLine(item);
                        }

                        Console.WriteLine("Güncellenecek ismi seçip yazınız: ");

                        string kullaniciVarolanSecim = Console.ReadLine();

                        if (degerListesi.Contains(kullaniciVarolanSecim))
                        {
                            int varolanIndex = degerListesi.IndexOf(kullaniciVarolanSecim);
                            degerListesi.RemoveAt(varolanIndex);
                            degerListesi.Add(kullaniciGelenDeger);

                            Console.WriteLine("Değer başarıyla güncellendi. ");
                        }
                        else
                        {
                            Console.WriteLine("Listeden veri seçmediniz!. ");
                        }

                        Console.WriteLine("Devam etmek için bir tuşa basınız");
                        Console.ReadLine();
                        break;
                    case "5":

                        Console.Write("Silmek istediğiniz değeri giriniz: ");
                        string girilenDeger4 = Console.ReadLine();

                        if (!degerListesi.Contains(girilenDeger4))
                        {
                            Console.WriteLine("Girdiğiniz {0} nesnesi arraylist de bulunamadı.", girilenDeger4);
                        }
                        else
                        {
                            int indexDegeri = degerListesi.IndexOf(girilenDeger4);

                            degerListesi.RemoveAt(indexDegeri);

                            Console.WriteLine("Girdiğiniz {0} nesnesi arraylist den başarıyla silindi!.", girilenDeger4);
                        }
                        Console.WriteLine("Devam etmek için bir tuşa basınız");
                        Console.ReadLine();

                        break;
                    default:
                        break;
                }
            } while (secilen != "6");

            Console.WriteLine("Görünen değer listesi şu şekildedir: ");

            foreach (var item in degerListesi)
            {
                Console.WriteLine(item);
            }

        }
        static void hashTablePractice()
        {
            Hashtable H1 = new Hashtable();

            string evetMiHayırMi = "";
            string girilenDegerTr = "";
            string girilenDegerEng = "";

            do
            {

                Console.WriteLine("Yeni Kayıt Eklemek İstiyor Musunuz : E/H");
                evetMiHayırMi = Console.ReadLine();
                if (evetMiHayırMi == "H")
                {
                    break;
                }

                Console.WriteLine("Kaydınızı Türkçe olarak giriniz :");
                girilenDegerTr = Console.ReadLine();

                Console.WriteLine("Kaydınızı İngilizce olarak giriniz :");
                girilenDegerEng = Console.ReadLine();

                H1.Add(girilenDegerTr, girilenDegerEng);

            } while (evetMiHayırMi == "E");


            foreach (DictionaryEntry item in H1)
            {
                Console.WriteLine("Tr: {0} = Eng: {1}", item.Key, item.Value);
            }

        }
        static void sortedList()
        {
            SortedList A1 = new SortedList();
            // Key value listesidir, Hashtable dan farkı içerideki keyleri A-Z sıralar veya
            //Sayıları küçükten büyüğe sıralar
        }
    }
}
