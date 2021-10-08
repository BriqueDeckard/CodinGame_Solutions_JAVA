namespace POC_DesignPatterns._1_AbstractFactory.Products.Abstracts
{
    using System;

    /// <summary>
    /// "AbstractProductB" class.
    /// </summary>
    public abstract class AbstractProductB
    {
        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        /// <exception cref="System.InvalidOperationException"></exception>
        public override string ToString()
        {
            return this.GetType().Name ?? throw new InvalidOperationException();
        }
    }
}