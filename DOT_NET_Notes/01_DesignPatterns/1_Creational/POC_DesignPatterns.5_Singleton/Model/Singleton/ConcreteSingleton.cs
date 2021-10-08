namespace POC_DesignPatterns._5_Singleton
{
    using System;

    /// <summary>
    /// ConcreteSingleton class.
    /// </summary>
    public class ConcreteSingleton
    {
        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <returns></returns>
        public static ConcreteSingleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ConcreteSingleton();
            }
            return _instance;
        }

        /// <summary>
        /// Operations this instance.
        /// </summary>
        public void Operation()
        {
            Logger.Logger.Log("ConcreteSingleton operation");
        }

        /// <summary>
        /// The instance
        /// </summary>
        private static ConcreteSingleton _instance = new ConcreteSingleton();

        /// <summary>
        /// Prevents a default instance of the <see cref="ConcreteSingleton"/> class from being created.
        /// </summary>
        private ConcreteSingleton()
        {
        }
    }
}