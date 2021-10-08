namespace POC_DesignPatterns._2_Bridge.Implementor
{
    using System;

    /// <summary>
    /// ConcreteImplementorA class.
    /// </summary>
    /// <seealso cref="AbstractImplementor" />
    internal class ConcreteImplementorA : AbstractImplementor
    {
        /// <summary>
        /// Operations the imp.
        /// </summary>
        public override void OperationImp()
        {
            base.OperationImp();
            Logger.Logger.Log(TAG + "OperationImp");
            Console.WriteLine(this.ToString());
        }

        /// <summary>
        /// The tag
        /// </summary>
        private const string TAG = "ConcreteImplementorA ";
    }
}