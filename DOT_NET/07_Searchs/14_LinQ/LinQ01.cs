using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Searchs.LinQ;

namespace Searchs.LinQ
{
    public class LinQ01
    {
        static void Main()
        {
            /*
            LinQ queries are deferred. The query var only stores the query commands.
            Query execution is deferred until we iterate with foreach loop.
            */
            //---- The 3 parts of a LINQ Query :----
            // 1. The data source
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            // 2. Query creation
            var numQuery = from num in numbers where (num % 2) == 0 select num;

            // 3. Query execution
            foreach (int num in numQuery)
            {
                Console.WriteLine("{0,1} ", num);
            }

            /*
            You can force the execution with the Count, Max, Average and First methods.
            */
            // 1. Query creation
            var evenNumbersQuery =
                from num in numbers where (num % 2) == 0 select num;

            int evenNumbersCount = evenNumbersQuery.Count();
            Console.WriteLine("Count : " + evenNumbersCount);

            Customer[] customers =
                new Customer[3]
                {
                    new Customer { Age = 30, City = "Nevers", Name = "Kylian" },
                    new Customer { Age = 52, City = "Paris", Name = "Oeude" },
                    new Customer { Age = 24, City = "Lyon", Name = "Sam" }
                }();

            IEnumerable<Customer> customerQuery =
                from cust in customers where cust.Age <= 25 select cust;

            foreach (Customer customer in customerQuery)
            {
                Console
                    .WriteLine("Name: " +
                    customer.Name +
                    ", " +
                    "Age: " +
                    customer.Age);
            }
        }
    }
}
