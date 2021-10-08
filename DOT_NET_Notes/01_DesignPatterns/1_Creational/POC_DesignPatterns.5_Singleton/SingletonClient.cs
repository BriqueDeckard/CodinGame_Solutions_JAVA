namespace POC_DesignPatterns._5_Singleton
{
    using System;

    /// <summary>
    /// SingletonClient class.
    /// </summary>
    public class SingletonClient
    {
        /// <summary>
        /// Demoes this instance.
        /// </summary>
        public void Demo()
        {
            ConcreteSingleton.GetInstance().Operation();
            Console.ReadLine();
        }
    }
}