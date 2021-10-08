namespace POC_DesignPatterns._2_Command.Command
{
    using System;

    /// <summary>
    ///Concrete command class.
    /// </summary>
    /// <seealso cref="AbstractCommand" />
    public class ConcreteCommand : AbstractCommand
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConcreteCommand"/> class.
        /// </summary>
        /// <param name="body">The body.</param>
        public ConcreteCommand(string body) : base("concrete" + body)
        {
        }

        /// <summary>
        /// Executes this instance.
        /// </summary>
        public override void Execute()
        {
            Console.WriteLine(this.GetType().FullName + " " + this.Body);
        }
    }
}