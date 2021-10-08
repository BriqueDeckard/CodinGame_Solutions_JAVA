namespace POC_DesignPatterns._5_Mediator
{
    using System;

    /// <summary>
    /// MediatorClient class.
    /// </summary>
    public class MediatorClient
    {
        /// <summary>
        /// Demoes this instance.
        /// </summary>
        public void Demo()
        {
            Mediated user1 = new Mediated("User1");
            Mediated user2 = new Mediated("User2");

            user1.DoOutputOperation(user2, "Transmission");
            user2.DoOutputOperation(user1, "Received");
            Console.ReadLine();
        }
    }
}