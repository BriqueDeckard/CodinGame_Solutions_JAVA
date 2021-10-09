namespace POC_DesignPatterns._3_Composite.Concretes
{
    using POC_DesignPatterns._3_Composite.Abstract;

    /// <summary>
    /// Leaf class.
    /// </summary>
    /// <seealso cref="AbstractComponent" />
    public class Leaf : AbstractComponent
    {
        /// <summary>
        /// Operations this instance.
        /// </summary>
        public override void Operation()
        {
            Logger.Logger.Log("Leaf operation --> End of the tree");
        }
    }
}