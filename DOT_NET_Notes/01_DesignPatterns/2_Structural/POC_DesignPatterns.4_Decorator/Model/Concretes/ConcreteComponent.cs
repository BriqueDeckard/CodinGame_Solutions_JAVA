namespace POC_DesignPatterns._4_Decorator.Concretes
{
    using _4_Decorator.Abstract;

    /// <summary>
    ///ConcreteComponent class.
    /// </summary>
    /// <seealso cref="AbstractComponent" />
    public class ConcreteComponent : AbstractComponent
    {
        /// <summary>
        /// Operations this instance.
        /// </summary>
        public override void Operation()
        {
            Logger.Logger.Log("ConcreteComponent Operation");
        }
    }
}