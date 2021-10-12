using System;
// ---- Obligatory to use LinQ on arrays ----
using System.Linq;

namespace _04_SortAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sort an array");
            SortAnArray();
            Console.WriteLine("Sort keys and values");
            SortKeyAndValues();
            Console.WriteLine("Sort an array with LinQ");
            SortAnArrayUsingLinq();
        }

        private static void SortKeyAndValues()
        {
            int[] numbers = { 2, 1, 4, 3 };
            String[] numberNames = { "two", "one", "four", "three" };
            Array.Sort (numbers, numberNames);

            Array.ForEach<int>(numbers, n => Console.WriteLine(n));
            Array.ForEach<string>(numberNames, n => Console.WriteLine(n));
        }

        private static void SortAnArray()
        {
            string[] animals =
            { "Cat", "Alligator", "Fox", "Donkey", "Bear", "Elephant", "Goat" };

            Array.Sort (animals); // Result: ["Alligator", "Bear", "Cat","Donkey","Elephant","Fox","Goat"]

            foreach (var item in animals)
            {
                Console.WriteLine (item);
            }
        }

        private static void SortAnArrayUsingLinq(){
            string[] animals =
            { "Cat", "Alligator", "Fox", "Donkey", "Bear", "Elephant", "Goat" };

            var sortedStr = from name in animals
                            orderby name   
                            select name;
            
            Array.ForEach<string>(sortedStr.ToArray<string>(), n => Console.WriteLine(n));
        }
    }
}
