using System;
using System.Text;

namespace _03_AreaRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez la longueur: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entrez la hauteur: ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console
                .WriteLine("L'aire est de : " +
                CalculateRectangleArea(length: length, height: height));
        }

        /// <summary>
        /// Calculates the rectangle's area
        /// </summary>
        /// <param name="length"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        private static string CalculateRectangleArea(int length, int height)
        {            
            var area = length * height;
            StringBuilder sb = new StringBuilder(""+area);
            return sb.ToString();
        }
    }
}
