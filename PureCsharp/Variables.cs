using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureCsharp
{
    public class Variables
    {
        static void StringChar()
        {
            /* STRING _ CHAR */
            string name = "Mert";

            string surname = "Bulutoglu";

            string allName = name + " " + surname;

            string longString = allName.ToUpper();

            string shortString = allName.ToLower();

            string rangeString = allName.Substring(0, 5);

            char selectedChar = 'A';


        }

        static void ByteInt()
        {
            /* BYTE _ INT */
            byte selectedByte = 0; //
            int selectedIndex = 0;

            byte byteMinValue = byte.MinValue; //0
            byte byteMaxValue = byte.MaxValue; //255

            int intMinValue = int.MinValue; // -2147483648
            int intMaxValue = int.MaxValue; // 2147483648


        }

        static void DoubleDecimalFloatDatetime()
        {
            /* DOUBLE _ DECIMAL _ FLOAT */

            double doubleVal1 = 10.2;
            double doubleVal2 = 10;
            double doubleVal3 = 10.9d;

            double doubleMinValue = double.MinValue;
            double doubleMaxValue = double.MaxValue;


            decimal decimalVal1 = 10.2M;

            decimal decimalMinValue = decimal.MinValue;
            decimal decimalMaxValue = decimal.MaxValue;


            float floatVal1 = 10.2F;

            float floatMinValue = float.MinValue;
            float floatMaxValue = float.MaxValue;


            DateTime dateTime = DateTime.Now;

        }

        static void TypeConversion()
        {
            /* TUR DONUSUMU */

            byte number1 = 10;

            int number2 = 256;

            byte number3 = (byte)number2;

        }

        static void Object()
        {

            object obj1 = 100;
            object obj2 = 10.9F;
            object obj3 = 22.1M;
            object obj4 = 22.1D;

        }

        static void ConvertParse()
        {

            string stringS = "100";

            int num1 = int.Parse(stringS);
            int num2 = Convert.ToInt32(stringS);

            string string2 = "True";

            bool b1 = bool.Parse(string2);
            bool b2 = Convert.ToBoolean(string2);


            string metin3 = null;

            decimal d1 = decimal.Parse(metin3); // null exception hatası fırlatır.
            decimal d2 = Convert.ToDecimal(metin3); // Hata fırlatmaz d2 yi 0 a eşitler.// Tavsiye

        }
    }
}
