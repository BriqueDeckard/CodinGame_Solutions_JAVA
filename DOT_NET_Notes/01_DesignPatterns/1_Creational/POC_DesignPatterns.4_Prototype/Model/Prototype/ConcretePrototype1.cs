namespace POC_DesignPatterns._4_Prototype
{
    /// <summary>
    /// ConcretePrototype1 class.
    /// </summary>
    /// <seealso cref="POC_DesignPatterns._4_Prototype.AbstractPrototype" />
    public class ConcretePrototype1 : AbstractPrototype
    {
        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns></returns>
        public override AbstractPrototype clone()
        {
            return new ConcretePrototype1();
        }
    }
}