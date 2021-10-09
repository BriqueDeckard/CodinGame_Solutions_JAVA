namespace POC_DesignPatterns._2_Bridge.Abstraction
{
    using POC_DesignPatterns._2_Bridge.Implementor;

    using System;

    /// <summary>
    /// RefinedAbstractionB class.
    /// </summary>
    /// <seealso cref="Abstraction" />
    public class RefinedAbstractionB : Abstraction
    {
        /// <summary>
        /// Operations this instance.
        /// </summary>
        public override void Operation()
        {
            this.Implementor = new ConcreteImplementorB();
            base.Operation();
            Logger.Logger.Log("Refined" + this.ToString());
        }
    }
}