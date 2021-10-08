namespace POC_DesignPatterns._6_Flyweight
{
    using System;

    /// <summary>
    /// AbstractFlyweight class.
    /// </summary>
    /// <seealso cref="POC_DesignPatterns._6_Flyweight.IFlyweight" />
    public abstract class AbstractFlyweight : IFlyweight
    {
        /// <summary>
        /// Operations the specified extrinsicstate.
        /// </summary>
        /// <param name="extrinsicstate">The extrinsicstate.</param>
        public virtual void Operation(int extrinsicstate)
        {
            Console.WriteLine("AbstractFlyweight: " + extrinsicstate);
        }
    }
}