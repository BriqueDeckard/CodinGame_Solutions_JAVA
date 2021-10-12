using System;

namespace _01_RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            // Random integer
            int num = rnd.Next();
            Console.WriteLine("One integer: {0} ", num);

            // Random integer in a range
            int min = 5;
            int max = 10;
            int num2 = rnd.Next(max);
            Console.WriteLine("One integer before {0} : {1} ", max, num2);

            int num3 = rnd.Next(min, max);
            Console
                .WriteLine("One integer between {0} and {1} : {2} ",
                min,
                max,
                num3);

            // Random floating point number
            double num4 = rnd.NextDouble();
            Console.WriteLine("One double : " + num4);

            // Random Bytes
            byte[] byte1 = new Byte[4];
            rnd.NextBytes (byte1);

            foreach (byte b in byte1)
            {
                Console.WriteLine("One byte : " + b);
            }
        }
    }
}
