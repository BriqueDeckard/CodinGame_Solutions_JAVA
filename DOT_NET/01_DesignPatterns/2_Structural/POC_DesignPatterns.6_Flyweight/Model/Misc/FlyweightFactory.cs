namespace POC_DesignPatterns._6_Flyweight
{
    using System.Collections;

    /// <summary>
    /// FlyweightFactory
    /// creates and manages flyweight objects ensures that flyweight are shared properly.
    /// When a client requests a flyweight, the FlyweightFactory objects assets an existing instance or creates one, if none exists.
    /// </summary>
    public class FlyweightFactory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlyweightFactory"/> class.
        /// </summary>
        public FlyweightFactory()
        {
            _flyweights.Add("X", new ConcreteFlyweight());

            _flyweights.Add("Y", new ConcreteFlyweight());

            _flyweights.Add("Z", new ConcreteFlyweight());
        }

        /// <summary>
        /// Gets the flyweight.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns></returns>
        public IFlyweight GetFlyweight(string key)

        {
            return ((IFlyweight)_flyweights[key]);
        }

        /// <summary>
        /// The flyweights
        /// </summary>
        private readonly Hashtable _flyweights = new Hashtable();
    }
}