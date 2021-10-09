namespace POC_DesignPatterns._3_FactoryMethod
{
    /// <summary>
    /// Concrete creator class.
    /// </summary>
    /// <seealso cref="AbstractCreator" />
    public class ConcreteCreator : AbstractCreator
    {
        /// <summary>
        /// Factories the method.
        /// </summary>
        /// <returns></returns>
        public override AbstractProduct FactoryMethod()
        {
            Logger.Logger.Log("ConcreteCreator FactoryMethod");
            return new ConcreteProduct();
        }
    }
}