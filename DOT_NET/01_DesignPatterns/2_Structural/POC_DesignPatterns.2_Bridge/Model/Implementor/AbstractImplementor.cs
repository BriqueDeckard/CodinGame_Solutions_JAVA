namespace POC_DesignPatterns._2_Bridge.Implementor
{
    using System;

    /// <summary>
    /// Implementor class.
    /// </summary>
    public class AbstractImplementor
    {
        /// <summary>
        /// Operations the imp.
        /// </summary>
        public virtual void OperationImp()
        {
            Logger.Logger.Log(this.ToString());
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        /// <exception cref="System.InvalidOperationException"></exception>
        public override string ToString()
        {
            return this.GetType().FullName ?? throw new InvalidOperationException();
        }
    }
}