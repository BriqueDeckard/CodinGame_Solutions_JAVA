namespace POC_DesignPatterns._4_Prototype
{
    using System;
    using System.Collections;

    /// <summary>
    /// Registry class to maintains a map associating Id to object type.
    /// </summary>
    public class Registry
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Registry"/> class.
        /// </summary>
        public Registry()
        {
            PrototypesHashtable.Add("Proto1", new ConcretePrototype1());
            PrototypesHashtable.Add("Proto2", new ConcretePrototype2());
        }

        /// <summary>
        /// Gets the prototype.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        public AbstractPrototype GetPrototype(string type)
        {
            try
            {
                return (AbstractPrototype)PrototypesHashtable[type];
            }
            catch (Exception e)
            {
                Logger.Logger.Log(e.Message);

                throw;
            }
        }

        /// <summary>
        /// The prototypes hashtable
        /// </summary>
        private static readonly Hashtable PrototypesHashtable = new Hashtable();
    }
}