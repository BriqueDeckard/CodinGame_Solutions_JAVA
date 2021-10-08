namespace POC_DesignPatterns._2_Bridge
{
    using POC_DesignPatterns._2_Bridge.Abstraction;

    using System;

    /// <summary>
    /// Client class.
    /// </summary>
    public class BridgeClient
    {
        /// <summary>
        /// Demo
        /// </summary>
        public void Demo()
        {
            Logger.Logger.Log(TAG + "Demo");
            Abstraction.Abstraction refinedAbstraction = new RefinedAbstractionA();
            refinedAbstraction.Operation();
            refinedAbstraction = new RefinedAbstractionB();
            refinedAbstraction.Operation();
            Console.ReadLine();
        }

        /// <summary>
        /// The tag
        /// </summary>
        private const string TAG = "BridgeClient ";
    }
}