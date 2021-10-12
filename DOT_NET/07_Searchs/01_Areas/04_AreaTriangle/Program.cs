using System;
using System.Text;

namespace _04_AreaTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez la longueur de la base: ");
            var baseLength = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entrez la hauteur du triangle: ");
            var height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(CalculateTriangleArea(baseLength, height));
        }

        /// <summary>
        /// Calculates triangle area
        /// </summary>
        /// <param name="baseLength"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        private static string CalculateTriangleArea(int baseLength, int height)
        {
            int area = (baseLength * height) / 2;
            StringBuilder sb = new StringBuilder("" + area);
            return sb.ToString();
        }
    }
}
