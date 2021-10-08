namespace POC_DesignPatterns._2_Bridge.Implementor
{
    using System;

    /// <summary>
    /// ConcreteImplementorB class.
    /// </summary>
    /// <seealso cref="AbstractImplementor" />
    internal class ConcreteImplementorB : AbstractImplementor
    {
        /// <summary>
        /// Operations the imp.
        /// </summary>
        public override void OperationImp()
        {
            base.OperationImp();
            Console.WriteLine(this.ToString());
        }
    }
}