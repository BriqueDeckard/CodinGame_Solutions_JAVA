namespace POC_DesignPatterns._2_Command.Command
{
    /// <summary>
    ///
    /// </summary>
    public abstract class AbstractCommand
    {
        /// <summary>
        /// The body
        /// </summary>
        public string Body;

        /// <summary>
        /// Executes this instance.
        /// </summary>
        public abstract void Execute();

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractCommand"/> class.
        /// </summary>
        /// <param name="body">The body.</param>
        protected AbstractCommand(string body)
        {
            Body = "abstract" + body;
        }
    }
}