using System;
using System.Diagnostics;

namespace _01_ExecutionTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = new Stopwatch();
            watch.Start();

            for (int i = 0; i < 1000; i++)
            {
                var j = i * i;
                if (j % 3 == 0)
                {
                    Console.Write (i);
                }
                Console.Write("-");
            }
            watch.Stop();
            Console
                .WriteLine($"\nExecution time: {watch.ElapsedMilliseconds} ms");

            // Some code here
            if (!watch.IsRunning)
            {
                watch.Start();
            }

            for (int i = 0; i < 1000; i++)
            {
                var j = i * i;
                if (j % 7 == 0)
                {
                    Console.Write (i);
                }
                Console.Write("-");
            }
            watch.Stop();
            Console
                .WriteLine($"\nExecution time: {watch.ElapsedMilliseconds} ms");
        }
    }
}
