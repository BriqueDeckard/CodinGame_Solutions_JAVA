namespace POC_DesignPatterns._7_Proxy.Sensible
{
    using System;

    /// <summary>
    /// RealSubject class.
    /// </summary>
    public class RealSubject
    {
        /// <summary>
        /// Does the protected request.
        /// </summary>
        protected void DoProtectedRequest()
        {
            Console.WriteLine("RealSubject protected request");
        }

        /// <summary>
        /// Does the private request.
        /// </summary>
        private void DoPrivateRequest()
        {
            Console.WriteLine("RealSubject private request");
        }
    }
}