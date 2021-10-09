namespace POC_DesignPatterns._7_Proxy
{
    using POC_DesignPatterns._7_Proxy.Sensible;

    using System;

    /// <summary>
    /// InheritanceProxy class.
    /// </summary>
    /// <seealso cref="RealSubject" />
    public abstract class InheritanceProxy : RealSubject
    {
        /// <summary>
        /// Operations this instance.
        /// </summary>
        public void DoOperation()
        {
            Console.WriteLine("InheritanceProxy DoOperation");
            base.DoProtectedRequest();
        }
    }
}