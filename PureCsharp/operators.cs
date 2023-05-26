using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureCsharp
{
    public class Operators
    {
        static void IsControl()
        {

            /* IS CONTROL */
            int s1 = 50;

            int s2 = 100;

            object o1 = s1;

            Console.WriteLine(o1);


            bool isControl = o1 is bool;

            bool isControl2 = o1 is int;

            bool isControl3 = o1 is long;

            bool isControl4 = o1 is ulong;
            bool isControl5 = o1 is float;
            bool isControl6 = o1 is double;
            bool isControl7 = o1 is decimal;
            bool isControl8 = o1 is Guid;
            bool isControl9 = o1 is DateTime;
            bool isControl10 = o1 is DateTimeOffset;

            bool isControl11 = o1 is TimeSpan;

            bool isControl12 = o1 is TimeSpan?;
        }
        public void giveName(string Name, string Surname)
        {
            Console.Write("Adınız soyadınız : {0} {1}", Name, Surname);
        }
        static void AsControl()
        {

            /*  AS OPERATOR */

            string nameSurname = "Mert Bulutoğlu";

            object objString = nameSurname;

            string resultString = objString as string;  //if it is string then assign it to resultString

            Console.ReadLine();
        }
    }
}
