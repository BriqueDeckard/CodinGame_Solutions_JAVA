using System;
using System.Globalization;

namespace _02_StringToInt
{
    class Program
    {
        static void Main(string[] args)
        {
            ParseDemo();
            ConvertDemo();
            TryParseDemo();
        }

        private static void TryParseDemo()
        {
            string numberStr = "1234";
            int number;

            bool isParsable = Int32.TryParse(numberStr, out number);

            if (isParsable)
            {
                Console.WriteLine("Parsed number {0}", number);
            }
            else
            {
                Console.WriteLine("Coul not be parsed");
            }
        }

        private static void ParseDemo()
        {
            Int16.Parse("100"); // returns 100
            Int16.Parse("(100)", NumberStyles.AllowParentheses); // returns -100

            int
                .Parse("30,000",
                NumberStyles.AllowThousands,
                new CultureInfo("en-au")); // returns 30000
            int.Parse("$ 10000", NumberStyles.AllowCurrencySymbol); //returns 10000
            int.Parse("-100", NumberStyles.AllowLeadingSign); // returns -100
            int
                .Parse(" 100 ",
                NumberStyles.AllowLeadingWhite |
                NumberStyles.AllowTrailingWhite); // returns 100

            Int64.Parse("2147483649"); // returns 2147483649
        }

        private static void ConvertDemo()
        {
            Convert.ToInt16("100"); // returns short
            Convert.ToInt16(null); //returns 0

            Convert.ToInt32("233300"); // returns int
            Convert.ToInt32("1234", 16); // returns 4660 - Hexadecimal of 1234

            Convert.ToInt64("1003232131321321"); //returns long

            // the following throw exceptions
            Convert.ToInt16(""); //throws FormatException
            Convert.ToInt32("30,000"); //throws FormatException
            Convert.ToInt16("(100)"); //throws FormatException
            Convert.ToInt16("100a"); //throws FormatException
            Convert.ToInt16(2147483649); //throws OverflowException
        }
    }
}
