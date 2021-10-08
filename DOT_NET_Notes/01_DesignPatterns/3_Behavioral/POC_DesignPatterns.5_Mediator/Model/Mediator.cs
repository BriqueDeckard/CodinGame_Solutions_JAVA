namespace POC_DesignPatterns._5_Mediator
{
    /// <summary>
    /// Mediator class.
    /// </summary>
    public class Mediator
    {
        /// <summary>
        /// Does the mediation.
        /// </summary>
        /// <param name="from">From.</param>
        /// <param name="to">To.</param>
        /// <param name="data">The data.</param>
        public static void DoMediation(Mediated from, Mediated to, string data)
        {
            string transmittedData = "[From " + from.Name + "] \n  " + data;
            to.DoInputOperation(transmittedData);
        }
    }
}