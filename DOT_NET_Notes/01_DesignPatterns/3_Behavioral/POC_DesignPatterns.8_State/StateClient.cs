namespace POC_DesignPatterns._8_State
{
    using POC_DesignPatterns._8_State.Model.Context;
    using POC_DesignPatterns._8_State.Model.States.Concretes;

    using System;

    /// <summary>
    /// StateClient class.
    /// </summary>
    public class StateClient
    {
        /// <summary>
        /// Demoes this instance.
        /// </summary>
        public void Demo()
        {
            AbstractContext context = new ConcreteContext();
            context.State = new RunState("Run");
            context.Request();
            context.State = new StopState("Stop");
            context.Request();
            context.State = new RunState("Run");
            context.Request();
            Console.ReadLine();
        }
    }
}