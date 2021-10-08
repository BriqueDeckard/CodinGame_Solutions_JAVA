namespace POC_DesignPatterns._6_Memento
{
    using System;

    /// <summary>
    /// MementoClient class.
    /// </summary>
    public class MementoClient
    {
        /// <summary>
        /// Demoes this instance.
        /// </summary>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Demo()
        {
            Logger.Logger.Log(intro);
            CareTaker careTaker = new CareTaker();
            careTaker.Care();
            Console.ReadLine();
        }

        private static string intro = "== Memento : \n" +
                                      "\tWithout violating encapsulation, capture and externalize an \n" +
                                      "\tobject's internal state so that the object can be restored to this state later\n";
    }
}