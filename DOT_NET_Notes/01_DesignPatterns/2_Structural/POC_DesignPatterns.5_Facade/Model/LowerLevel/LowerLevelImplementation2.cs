namespace POC_DesignPatterns._5_Facade
{
    /// <summary>
    /// LowerLevelImplementation2 class.
    /// </summary>
    /// <seealso cref="ILowerLevelInterface2" />
    public class LowerLevelImplementation2 : ILowerLevelInterface2
    {
        /// <summary>
        /// Operations this instance.
        /// </summary>
        public void Operation()
        {
            Logger.Logger.Log("Lower Level 2 Operation");
        }
    }
}