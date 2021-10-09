using System;

namespace _02_StringToEnum
{
    class Program
    {
#region Enum
        enum Week
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
#endregion


        static void Main(string[] args)
        {
            var day1 = "Monday";
            var day2 = "MONDAY";
            var day3 = "SomeOherDay";

            Week
                week1,
                week2,
                week3;

            if (Enum.TryParse<Week>(day1, out week1))
            {
                Console.WriteLine("{0} converted to {1}", day1, week1);
            }

            if (Enum.TryParse<Week>(day2, out week2))
            {
                Console.WriteLine("{0} converted to {1}", day2, week2);
            }
        }
    }
}
