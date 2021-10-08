namespace POC_DesignPatterns._6_Memento
{
    /// <summary>
    /// Memento class.
    /// </summary>
    public class Memento
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Memento"/> class.
        /// </summary>
        /// <param name="stateToSave">The state to save.</param>
        public Memento(string stateToSave)
        {
            this.SavedState = stateToSave;
        }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        public string SavedState { get; set; }
    }
}