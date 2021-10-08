namespace POC_DesignPatterns._7_Proxy
{
    using POC_DesignPatterns._7_Proxy.Accessible;

    using System;

    /// <summary>
    /// Proxy client class.
    /// </summary>
    public class ProxyClient
    {
        /// <summary>
        /// Demoes this instance.
        /// </summary>
        public void Demo()
        {
            AccessibleSubject accessibleSubject = new AccessibleSubject();
            accessibleSubject.DoOperation();
            Console.ReadLine();
        }
    }
}