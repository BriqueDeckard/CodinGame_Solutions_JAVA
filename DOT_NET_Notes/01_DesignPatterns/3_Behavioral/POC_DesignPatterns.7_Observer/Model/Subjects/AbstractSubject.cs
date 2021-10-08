namespace POC_DesignPatterns._7_Observer.Model.Subjects
{
    using POC_DesignPatterns._7_Observer.Model.Observers;

    using System;
    using System.Collections.Generic;

    /// <summary>
    /// "AbstractSubject" class.
    /// </summary>
    /// <seealso cref="ISubject" />
    public abstract class AbstractSubject : ISubject
    {
        /// <summary>
        /// Gets or sets the observers.
        /// </summary>
        /// <value>
        /// The observers.
        /// </value>
        public List<IObserver> Observers
        {
            get
            {
                if (_observers == null)
                {
                    _observers = new List<IObserver>();
                }

                return _observers;
            }
            set
            {
                if (_observers == null)
                {
                    _observers = new List<IObserver>();
                }
                _observers = value;
            }
        }

        /// <summary>
        /// Attaches the specified observer.
        /// </summary>
        /// <param name="observer">The observer.</param>
        /// <exception cref="System.ArgumentNullException"></exception>
        public void Attach(IObserver observer)
        {
            if (observer == null)
            {
                throw new ArgumentNullException();
            }
            Observers.Add(observer);
        }

        /// <summary>
        /// Detaches the specified observer.
        /// </summary>
        /// <param name="observer">The observer.</param>
        /// <exception cref="System.ArgumentNullException"></exception>
        public void Detach(IObserver observer)
        {
            if (observer == null)
            {
                throw new ArgumentNullException();
            }
            Observers.Remove(observer);
        }

        /// <summary>
        /// Notifies the specified state.
        /// </summary>
        /// <param name="state">The state.</param>
        public void Notify(string state)
        {
            foreach (IObserver observer in Observers)
            {
                observer.Update(this.GetType().Name + " " + state);
            }
        }

        /// <summary>
        /// The observers
        /// </summary>
        private List<IObserver> _observers;
    }
}