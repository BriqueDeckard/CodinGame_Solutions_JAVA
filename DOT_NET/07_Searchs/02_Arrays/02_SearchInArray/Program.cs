using System;

namespace _02_SearchInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Rick", "Sam", "Samantha", "Mila", "Rose" };
            var stringToFind = "Sam";

            // ---- Find
            var data1 = Array.Find<string>(names, n => n == stringToFind);
            Console.WriteLine("Result: " + data1);

            // ---- StartsWith
            var data2 = Array.Find(names, n => n.StartsWith("Sa"));
            Console.WriteLine("Data: " + data2);

            // ---- Find All
            var data3 = Array.FindAll(names, n => n.StartsWith("Sa"));
            foreach (var item in data3)
            {
                Console.WriteLine("Item starting with Sa : " + item);
            }
        }
    }
}
