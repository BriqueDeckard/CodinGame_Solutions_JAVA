namespace POC_DesignPatterns._1_Adapter.Adapter.Inheritance
{
    using POC_DesignPatterns._1_Adapter.Targets;

    /// <summary>
    /// Inheritance adapter class.
    /// </summary>
    /// <seealso cref="Adaptee" />
    /// <seealso cref="ITarget" />
    public class InheritanceAdapter : Adaptee, ITarget
    {
        /// <summary>
        /// Requests this instance.
        /// </summary>
        public void Request()
        {
            Logger.Logger.Log(TAG + "Request");
            this.SpecificRequet();
        }

        /// <summary>
        /// The tag
        /// </summary>
        private const string TAG = "InheritanceAdapter ";
    }
}