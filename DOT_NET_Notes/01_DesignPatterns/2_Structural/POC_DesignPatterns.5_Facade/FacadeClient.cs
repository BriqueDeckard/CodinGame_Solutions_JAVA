namespace POC_DesignPatterns._5_Facade
{
    using System;

    /// <summary>
    /// Facade client class.
    /// </summary>
    public class FacadeClient
    {
        /// <summary>
        /// Demoes this instance.
        /// </summary>
        public void Demo()
        {
            imp1Operation();
            imp2Operation();
            Console.ReadLine();
        }

        /// <summary>
        /// Imp1s the operation.
        /// </summary>
        public void imp1Operation()
        {
            implementation1 = new LowerLevelImplementation1();
            implementation1.Operation();
        }

        /// <summary>
        /// Imp2s the operation.
        /// </summary>
        public void imp2Operation()
        {
            implementation2 = new LowerLevelImplementation2();
            implementation2.Operation();
        }

        /// <summary>
        /// The implementation1
        /// </summary>
        private IHigherLevelInterface implementation1;

        /// <summary>
        /// The implementation2
        /// </summary>
        private IHigherLevelInterface implementation2;
    }
}