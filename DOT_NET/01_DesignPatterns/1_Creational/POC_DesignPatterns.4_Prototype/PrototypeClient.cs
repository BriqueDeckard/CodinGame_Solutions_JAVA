namespace POC_DesignPatterns._4_Prototype
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// PrototypeClient class.
    /// </summary>
    public class PrototypeClient
    {
        /// <summary>
        /// Demoes this instance.
        /// </summary>
        public void Demo()
        {
            Registry registry = new Registry();
            List<string> prototypeNames = new List<string>()
            {
                "Proto1",
                "Proto2",
            };

            foreach (string prototypeName in prototypeNames)
            {
                AbstractPrototype prototype = registry.GetPrototype(prototypeName);
                if (prototype != null)
                {
                    Logger.Logger.Log(prototype.ToString());
                }
            }

            Console.ReadLine();
        }
    }
}