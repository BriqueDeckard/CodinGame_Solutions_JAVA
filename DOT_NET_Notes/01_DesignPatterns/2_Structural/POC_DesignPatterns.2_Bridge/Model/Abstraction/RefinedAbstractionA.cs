namespace POC_DesignPatterns._2_Bridge.Abstraction
{
    using POC_DesignPatterns._2_Bridge.Implementor;

    /// <summary>
    /// RefinedAbstraction class.
    /// </summary>
    /// <seealso cref="Abstraction" />
    internal class RefinedAbstractionA : Abstraction
    {
        /// <summary>
        /// Operations this instance.
        /// </summary>
        public override void Operation()
        {
            this.Implementor = new ConcreteImplementorA();
            base.Operation();
            Logger.Logger.Log("Refined" + this.ToString());
        }
    }
}