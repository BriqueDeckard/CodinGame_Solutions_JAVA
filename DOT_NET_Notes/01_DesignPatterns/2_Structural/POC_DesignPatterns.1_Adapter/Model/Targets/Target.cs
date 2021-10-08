namespace POC_DesignPatterns._1_Adapter.Targets
{
    using System;

    /// <summary>
    /// Target class.
    /// </summary>
    /// <seealso cref="ITarget" />
    public class Target : ITarget
    {
        /// <summary>
        /// Requests this instance.
        /// </summary>
        public void Request()
        {
            Logger.Logger.Log(TAG + "Request");
            Logger.Logger.Log(this.ToString());
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        /// <exception cref="System.InvalidOperationException"></exception>
        public override string ToString()
        {
            return this.GetType().FullName ?? throw new InvalidOperationException();
        }

        /// <summary>
        /// The tag
        /// </summary>
        private const string TAG = "Target ";
    }
}