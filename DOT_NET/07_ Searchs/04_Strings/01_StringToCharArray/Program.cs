using System;

namespace _01_StringToCharArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Hello world";
            char[] charArray = sentence.ToCharArray();
            foreach (char ch in charArray)
            {
                Console.WriteLine("c: " + ch);
            }

            string charString = new string(charArray);
            Console.WriteLine (charString);
        }
    }
}
