namespace POC_DesignPatterns._7_Observer
{
    using POC_DesignPatterns._7_Observer.Model.Observers;
    using POC_DesignPatterns._7_Observer.Model.Subjects;

    using System;

    /// <summary>
    /// ObserverClient class.
    /// </summary>
    public class ObserverClient
    {
        /// <summary>
        /// Demoes this instance.
        /// </summary>
        public void Demo()
        {
            ConcreteSubject concreteSubject = new ConcreteSubject();
            AbstractSubject abstractSubject = new ConcreteSubject();
            ConcreteObserver concreteObserver = new ConcreteObserver();
            AbstractObserver abstractObserver = new ConcreteObserver();

            concreteSubject.Attach(concreteObserver);
            concreteSubject.Attach(abstractObserver);

            abstractSubject.Attach(concreteObserver);
            abstractSubject.Attach(abstractObserver);

            concreteSubject.Notify("Hello ?");
            abstractSubject.Notify("Yeah ?");
            Console.ReadLine();
        }
    }
}