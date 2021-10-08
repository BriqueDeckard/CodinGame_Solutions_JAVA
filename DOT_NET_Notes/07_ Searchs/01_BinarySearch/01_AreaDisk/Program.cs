using System;

namespace _01_AreaDisk
{
    class Program
    {
        static void Main(string[] args)
        {
            int ray;
            float
                area,
                pi = 3.14F;
            Console.WriteLine("Entrez le rayon du cercle : ");
            var temp = Console.ReadLine();
            try
            {
                ray = Convert.ToInt32(temp);
            }
            catch (System.Exception e)
            {
                throw e;
            }
            area = pi * ray * ray;
            Console.WriteLine("La surface du cercle est de  : " + area);
        }
    }
}
