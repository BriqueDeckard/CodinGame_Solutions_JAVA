namespace POC_DesignPatterns._1_Adapter.Adapter
{
    using System;

    /// <summary>
    /// Adaptee class.
    /// </summary>
    public class Adaptee
    {
        /// <summary>
        /// Specifics the requet.
        /// </summary>
        public void SpecificRequet()
        {
            Logger.Logger.Log(TAG + "SpecificRequet");
            Logger.Logger.Log("__" + this.ToString());
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
        private const string TAG = "Adaptee ";
    }
}