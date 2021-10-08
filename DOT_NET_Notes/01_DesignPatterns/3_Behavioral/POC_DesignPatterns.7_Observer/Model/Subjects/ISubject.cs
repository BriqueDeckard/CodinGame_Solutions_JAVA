namespace POC_DesignPatterns._7_Observer.Model.Subjects
{
    using POC_DesignPatterns._7_Observer.Model.Observers;

    /// <summary>
    /// Interface for Subject object
    /// </summary>
    public interface ISubject
    {
        /// <summary>
        /// Attaches the specified observer.
        /// </summary>
        /// <param name="observer">The observer.</param>
        void Attach(IObserver observer);

        /// <summary>
        /// Detaches the specified observer.
        /// </summary>
        /// <param name="observer">The observer.</param>
        void Detach(IObserver observer);

        /// <summary>
        /// Notifies the specified state.
        /// </summary>
        /// <param name="state">The state.</param>
        void Notify(string state);
    }
}