using System;
// ---- Obligatory to use "Select" on arrays ----
using System.Linq;

namespace _03_ArrayToCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---- From a string array ---
            string[] animals = { "Cat", "Alligator", "Fox", "Donkey" };
            var str = String.Join(",", animals);
            Console.WriteLine("CSV : " + str);

            // ---- From an interger array ----
            int[] nums = { 1, 2, 3, 4 };
            str = String.Join(",", nums);
            Console.WriteLine("CSV : " + str);

            // ---- From an objects array ----
            Person[] people =
            {
                new Person() { Name = "Steve", Age = 45 },
                new Person() { Name = "Marcus", Age = 28 },
                new Person() { Name = "Mary", Age = 38 }
            };
            str = String.Join(",", people.Select(p => p.Name));
            Console.WriteLine("CSV : " + str);
        }
    }
}
