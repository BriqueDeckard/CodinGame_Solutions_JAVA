namespace POC_DesignPatterns._7_Observer.Model.Observers
{
    /// <summary>
    /// Interface for Observer object.
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// Updates the specified state.
        /// </summary>
        /// <param name="state">The state.</param>
        void Update(string state);
    }
}