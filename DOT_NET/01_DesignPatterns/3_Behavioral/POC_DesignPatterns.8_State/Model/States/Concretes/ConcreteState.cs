namespace POC_DesignPatterns._8_State.Model.States.Concretes
{
    using POC_DesignPatterns._8_State.Model.States.Abstract;

    /// <summary>
    /// ConcreteState class.
    /// </summary>
    /// <seealso cref="AbstractState" />
    public class ConcreteState : AbstractState
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConcreteState"/> class.
        /// </summary>
        /// <param name="title">The title.</param>
        public ConcreteState(string title) : base(title)
        {
        }
    }
}