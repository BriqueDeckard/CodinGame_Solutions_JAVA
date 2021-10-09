namespace POC_DesignPatterns._1_Adapter.Adapter.Composition
{
    using POC_DesignPatterns._1_Adapter.Targets;

    /// <summary>
    /// Composite adapter class.
    /// </summary>
    /// <seealso cref="ITarget" />
    public class CompositeAdapter : ITarget
    {
        /// <summary>
        /// The request.
        /// </summary>
        public void Request()
        {
            Logger.Logger.Log(TAG + "Request");
            if (_adaptee == null)
            {
                _adaptee = new Adaptee();
            }
            _adaptee.SpecificRequet();
        }

        private const string TAG = "CompositeAdapter ";

        /// <summary>
        /// The adaptee
        /// </summary>
        private Adaptee _adaptee;
    }
}