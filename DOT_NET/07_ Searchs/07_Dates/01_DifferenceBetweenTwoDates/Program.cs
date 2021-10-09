using System;

namespace _01_DifferenceBetweenTwoDates
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---- Difference ----
            // Declare dates
            var today = DateTime.Now;
            var previousDate = new DateTime(2021, 7, 15); // 15 July 2021

            // Get difference
            var diffOfDates = today - previousDate;

            Console.WriteLine("Difference in Timespan: {0}", diffOfDates);
            Console.WriteLine("Difference in Days: {0}", diffOfDates.Days);
            Console.WriteLine("Difference in Hours: {0}", diffOfDates.Hours);
            Console
                .WriteLine("Difference in Miniutes: {0}", diffOfDates.Minutes);
            Console
                .WriteLine("Difference in Seconds: {0}", diffOfDates.Seconds);
            Console
                .WriteLine("Difference in Milliseconds: {0}",
                diffOfDates.Milliseconds);
            Console.WriteLine("Difference in Ticks: {0}", diffOfDates.Ticks);

            // ---- Differences with timespan ----
            DateTime dt1 = new DateTime(2020, 4, 11, 4, 0, 12); //11 April 2020 4:00:12
            DateTime dt2 = new DateTime(2020, 5, 11, 5, 20, 28); //11 May 2020 5:20:28
            DateTime dt3 = new DateTime(2020, 6, 11); //11 June 2020 0:00:00
            TimeSpan interval = new TimeSpan(2, 14, 18); // 02:14:15

            TimeSpan diff1 = dt2 - dt1; //DateTime - DateTime
            TimeSpan diff2 = dt3 - dt2; //Date - DateTime
            DateTime diff3 = dt3 - interval; //Date - TimeSpan
            DateTime diff4 = dt2 - interval; //DateTime - TimeSpan

            //interval.Subtract(dt3); // error
            Console.WriteLine("{0} - {1} = {2}", dt2, dt1, diff1);
            Console.WriteLine("{0} - {1} = {2}", dt3, dt2, diff2);
            Console.WriteLine("{0} - {1} = {2}", dt3, interval, diff3);
            Console.WriteLine("{0} - {1} = {2}", dt2, interval, diff4);

            // ---- Substract ----
            // Declare two dates
            var prevDate = new DateTime(2021, 7, 15); //15 July 2021

            //get difference of two dates
            diffOfDates = today.Subtract(prevDate);

            Console.WriteLine("Difference in Timespan: {0}", diffOfDates);
            Console.WriteLine("Difference in Days: {0}", diffOfDates.Days);
            Console.WriteLine("Difference in Hours: {0}", diffOfDates.Hours);
            Console
                .WriteLine("Difference in Miniutes: {0}", diffOfDates.Minutes);
            Console
                .WriteLine("Difference in Seconds: {0}", diffOfDates.Seconds);
            Console
                .WriteLine("Difference in Milliseconds: {0}",
                diffOfDates.Milliseconds);
            Console.WriteLine("Difference in Ticks: {0}", diffOfDates.Ticks);

            dt1 = new DateTime(2020, 4, 11, 4, 0, 12); //11 April 2020 4:00:12
            dt2 = new DateTime(2020, 5, 11, 5, 20, 28); //11 May 2020 5:20:28
            dt3 = new DateTime(2020, 6, 11); //11 June 2020 0:00:00
            interval = new TimeSpan(2, 14, 18); // 02:14:15

            diff1 = dt2.Subtract(dt1); //DateTime - DateTime
            diff2 = dt3.Subtract(dt2); //Date - DateTime
            diff3 = dt3.Subtract(interval); //Date - TimeSpan
            diff4 = dt2.Subtract(interval); //DateTime - TimeSpan

            //interval.Subtract(dt3); // error
            Console.WriteLine("{0} - {1} = {2}", dt2, dt1, diff1);
            Console.WriteLine("{0} - {1} = {2}", dt3, dt2, diff2);
            Console.WriteLine("{0} - {1} = {2}", dt3, interval, diff3);
            Console.WriteLine("{0} - {1} = {2}", dt2, interval, diff4);
        }
    }
}
