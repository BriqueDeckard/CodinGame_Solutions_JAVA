namespace POC_DesignPatterns._6_Flyweight
{
    /// <summary>
    /// interface through which flyweights can receive and act on extrinsic state.
    /// </summary>
    public interface IFlyweight
    {
        /// <summary>
        /// Operations the specified extrinsictstate.
        /// </summary>
        /// <param name="extrinsictstate">The extrinsictstate.</param>
        void Operation(int extrinsictstate);
    }
}