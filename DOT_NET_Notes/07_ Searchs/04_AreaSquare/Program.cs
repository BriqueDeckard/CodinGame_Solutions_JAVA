using System;
using System.Text;

namespace _04_AreaSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez la longueur du côté");
            int side = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(CalculateSquareArea(side));
        }

        private static string CalculateSquareArea(int side)
        {
            var area = side * side;
            StringBuilder sb = new StringBuilder("" + area);
            return sb.ToString();
        }
    }
}
