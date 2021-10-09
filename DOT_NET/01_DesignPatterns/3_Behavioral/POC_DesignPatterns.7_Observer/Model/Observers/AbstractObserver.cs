namespace POC_DesignPatterns._7_Observer.Model.Observers
{
    /// <summary>
    /// AbstractObserver class.
    /// </summary>
    /// <seealso cref="IObserver" />
    public abstract class AbstractObserver : IObserver
    {
        /// <summary>
        /// Updates the specified state.
        /// </summary>
        /// <param name="state">The state.</param>
        public void Update(string state)
        {
            Logger.Logger.Log(this.GetType().Name + " " + state);
        }
    }
}