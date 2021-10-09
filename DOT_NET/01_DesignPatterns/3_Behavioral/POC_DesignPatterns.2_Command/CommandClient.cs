namespace POC_DesignPatterns._2_Command
{
    using POC_DesignPatterns._2_Command.Actors;
    using POC_DesignPatterns._2_Command.Command;

    using System;

    /// <summary>
    /// Command client class.
    /// </summary>
    public class CommandClient
    {
        /// <summary>
        /// Demo
        /// </summary>
        public void Demo()
        {
            Invoker invoker = new Invoker();
            Receiver receiver = new Receiver();
            foreach (AbstractCommand command in invoker.Commands)
            {
                receiver.Action(command);
            }

            Console.ReadLine();
        }
    }
}