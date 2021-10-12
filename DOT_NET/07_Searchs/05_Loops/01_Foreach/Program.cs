using System;
using System.Collections.Generic;

namespace _01_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---- With an array ----
            string[] replicants = { "John", "Doe", "Rosie", "Eugene" };
            foreach (string replicant in replicants)
            {
                Console.WriteLine("{0}", replicant);
            }

            // ---- With a List ----
            List<string> bladeRunners =
                new List<string>() { "Rick Deckard", "Samuel Truth" };
            foreach (string bladeRunner in bladeRunners)
            {
                Console.WriteLine("{0}", bladeRunner);
            }

            // ---- With the ForEach extension method ----
            bladeRunners.ForEach(bladeRunner => Console.WriteLine(bladeRunner));

            // ---- With a Dictionnary ----
            var animals =
                new Dictionary<string, string>()
                { { "OV", "Sheep, goat" }, { "BI", "Howl, Raven" } };

            foreach (var animal in animals)
            {
                Console.WriteLine("{0} - {1}", animal.Key, animal.Value);
            }

            // ---- With a custom implementation of IEnumerator ----
            DoubleStructure doubleEnumerator = new DoubleStructure();

            foreach (var theDouble in doubleEnumerator)
            {
                Console.WriteLine (theDouble);
            }

            CustomerEnumerable shop = new CustomerEnumerable();

            foreach (Customer cust in shop)
            {
                Console.WriteLine(cust.Name);
            }
        }
    }
}
