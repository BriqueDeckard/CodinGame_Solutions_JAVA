using System;

namespace _01_EnumCast
{
    public enum Week
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    class Program
    {
        static void Main(string[] args)
        {
            int
                i = 2,
                j = 6,
                k = 10;
            Week
                day1,
                day2,
                day3;

            day1 = (Week) i; //Wednesday
            Console.WriteLine("Day1: {0}", day1);
            day2 = (Week) j; //Sunday
            Console.WriteLine("Day2: {0}", day2);
            day3 = (Week) k; //10
            Console.WriteLine("Day3: {0}", day3);

            day1 = (Week) Enum.ToObject(typeof (Week), i); //Wednesday
            day2 = (Week) Enum.ToObject(typeof (Week), j); //Sunday
            day3 = (Week) Enum.ToObject(typeof (Week), k); //10
            Console.WriteLine("Day1: {0}", day1);
            Console.WriteLine("Day2: {0}", day2);
            Console.WriteLine("Day3: {0}", day3);
        }
    }
}
