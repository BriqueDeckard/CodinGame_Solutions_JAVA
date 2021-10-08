namespace POC_DesignPatterns._2_Command.Actors
{
    using POC_DesignPatterns._2_Command.Command;

    using System.Collections.Generic;

    /// <summary>
    /// Invoker class.
    /// </summary>
    public class Invoker
    {
        /// <summary>
        /// The commands
        /// </summary>
        public IList<AbstractCommand> Commands;

        /// <summary>
        /// Initializes a new instance of the <see cref="Invoker"/> class.
        /// </summary>
        public Invoker()
        {
            Commands = new List<AbstractCommand>()
            {
                new ConcreteCommand("001"),
                new ConcreteCommand("002"),
                new ConcreteCommand("003")
            };
        }
    }
}