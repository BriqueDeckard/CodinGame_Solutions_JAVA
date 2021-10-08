namespace POC_DesignPatterns._6_Flyweight
{
    using System;

    /// <summary>
    /// ConcreteFlyweight class.
    /// implements the Flyweight interface and adds storage for intrinsic state, if any.
    /// A ConcreteFlyweight object must be sharable.
    /// Any state it stores must be intrinsic, that is, it must be independent of the ConcreteFlyweight object's context.
    /// </summary>
    /// <seealso cref="AbstractFlyweight" />
    public class ConcreteFlyweight : AbstractFlyweight
    {
        /// <summary>
        /// Operations the specified extrinsicstate.
        /// </summary>
        /// <param name="extrinsicstate">The extrinsicstate.</param>
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("ConcreteFlyweight: " + extrinsicstate);
        }
    }
}