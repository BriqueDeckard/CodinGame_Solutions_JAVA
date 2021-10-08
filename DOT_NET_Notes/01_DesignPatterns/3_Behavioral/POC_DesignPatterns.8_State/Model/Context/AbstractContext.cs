namespace POC_DesignPatterns._8_State.Model.Context
{
    using POC_DesignPatterns._8_State.Model.States.Abstract;
    using POC_DesignPatterns._8_State.Model.States.Concretes;

    /// <summary>
    /// AbstractContext class.
    /// </summary>
    /// <seealso cref="IContext" />
    public abstract class AbstractContext : IContext
    {
        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        public AbstractState State { get => _state ?? new ConcreteState("nullstate"); set => _state = value; }

        /// <summary>
        /// Requests this instance.
        /// </summary>
        public void Request()
        {
            if (State.GetType().Name.Equals(States.States.RunState.ToString()))
            {
                State.Handle(this);
            }
            else
            {
                Logger.Logger.Log("No handling");
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractContext"/> class.
        /// </summary>
        protected AbstractContext()
        {
            _state = null;
        }

        /// <summary>
        /// The state
        /// </summary>
        private AbstractState _state;
    }
}