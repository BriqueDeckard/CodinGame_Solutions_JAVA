namespace POC_DesignPatterns._4_Iterator.Contracts
{
    using System;

    /// <summary>
    /// Iterator interface.
    /// </summary>
    public interface IIterator
    {
        /// <summary>
        /// Gets the next.
        /// </summary>
        /// <returns></returns>
        Object GetNext();

        /// <summary>
        /// Determines whether this instance has next.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance has next; otherwise, <c>false</c>.
        /// </returns>
        bool HasNext();
    }
}