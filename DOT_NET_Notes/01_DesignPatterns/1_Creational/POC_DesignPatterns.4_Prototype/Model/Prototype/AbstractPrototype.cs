namespace POC_DesignPatterns._4_Prototype
{
    using System;

    /// <summary>
    ///
    /// </summary>
    public abstract class AbstractPrototype
    {
        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns></returns>
        public abstract AbstractPrototype clone();

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        /// <exception cref="System.InvalidOperationException"></exception>
        public override string ToString()
        {
            return GetType().FullName ?? throw new InvalidOperationException();
        }
    }
}