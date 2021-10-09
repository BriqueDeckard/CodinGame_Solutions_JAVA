using System;
using System.Text;

namespace _01_ArraysManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays creation
            int[] array1 = new int[3] { 1, 2, 3 };

            // Array loop
            for (int i = 0; i < array1.Length; i++)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("Array at "+i+" is " + array1[i]);
                Console.WriteLine(sb.ToString());
            }
        }
    }
}
