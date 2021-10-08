namespace POC_DesignPatterns._6_Flyweight
{
    using System;

    /// <summary>
    /// Unshared concrete flyweight class.
    /// </summary>
    /// <seealso cref="AbstractFlyweight" />
    public class UnsharedConcreteFlyweight : AbstractFlyweight
    {
        /// <summary>
        /// Operations the specified extrinsicstate.
        /// </summary>
        /// <param name="extrinsicstate">The extrinsicstate.</param>
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("UnsharedConcreteFlyweight: " +

                              extrinsicstate);
        }
    }
}