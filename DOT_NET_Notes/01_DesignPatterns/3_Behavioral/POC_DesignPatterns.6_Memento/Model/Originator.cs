namespace POC_DesignPatterns._6_Memento
{
    using System;

    /// <summary>
    /// Originator class.
    /// </summary>
    public class Originator
    {
        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        public string State
        {
            private get { return this._state; }
            set
            {
                Console.WriteLine("Originator: setting state to " + value);
                this._state = value;
            }
        }

        /// <summary>
        /// Restores from memento.
        /// </summary>
        /// <param name="memento">The memento.</param>
        /// <exception cref="System.ArgumentNullException"></exception>
        public void RestoreFromMemento(Memento memento)
        {
            Console.WriteLine("Restoring from memento");
            if (memento == null)
            {
                throw new ArgumentNullException();
            }

            this.State = memento.SavedState;
        }

        /// <summary>
        /// Saves to memento.
        /// </summary>
        /// <returns></returns>
        public Memento SaveToMemento()
        {
            Console.WriteLine("Saving to memento");
            return new Memento(State);
        }

        /// <summary>
        /// The state
        /// </summary>
        private string _state;
    }
}