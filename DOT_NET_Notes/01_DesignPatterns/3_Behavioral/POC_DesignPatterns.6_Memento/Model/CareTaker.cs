namespace POC_DesignPatterns._6_Memento
{
    using System.Collections.Generic;

    /// <summary>
    /// CareTaker class.
    /// </summary>
    public class CareTaker
    {
        /// <summary>
        /// Cares this instance.
        /// </summary>
        public void Care()
        {
            List<Memento> savedStates = new List<Memento>();

            Originator originator = new Originator();
            originator.State = "State1";
            originator.State = "State2";
            savedStates.Add(originator.SaveToMemento());
            originator.State = "State3";
            savedStates.Add(originator.SaveToMemento());
            originator.State = "State4";

            originator.RestoreFromMemento(savedStates.Find(m => m.SavedState == "State2"));
        }
    }
}