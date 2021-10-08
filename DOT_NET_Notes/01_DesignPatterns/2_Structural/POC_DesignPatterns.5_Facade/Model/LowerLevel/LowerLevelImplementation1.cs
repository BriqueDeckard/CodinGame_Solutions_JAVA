namespace POC_DesignPatterns._5_Facade
{
    /// <summary>
    /// LowerLevelImplementation1 class.
    /// </summary>
    /// <seealso cref="ILowerLevelInterface1" />
    public class LowerLevelImplementation1 : ILowerLevelInterface1
    {
        /// <summary>
        /// Operations this instance.
        /// </summary>
        public void Operation()
        {
            Logger.Logger.Log("Lower Level 1 Operation");
        }
    }
}