namespace POC_DesignPatterns._2_Command.Actors
{
    using POC_DesignPatterns._2_Command.Command;

    /// <summary>
    /// Receiver class.
    /// </summary>
    public class Receiver
    {
        /// <summary>
        /// Actions the specified command.
        /// </summary>
        /// <param name="command">The command.</param>
        public void Action(AbstractCommand command)
        {
            command.Execute();
        }
    }
}