namespace POC_DesignPatterns._8_State.Model.States.Abstract
{
    using POC_DesignPatterns._8_State.Model.Context;

    /// <summary>
    /// AbstractState class.
    /// </summary>
    /// <seealso cref="IState" />
    public abstract class AbstractState : IState
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title { get; set; }

        /// <summary>
        /// Handles the specified context.
        /// </summary>
        /// <param name="context">The context.</param>
        public virtual void Handle(IContext context)
        {
            Logger.Logger.Log("State ->" + this.Title);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractState"/> class.
        /// </summary>
        /// <param name="title">The title.</param>
        protected AbstractState(string title)
        {
            Title = title;
        }
    }
}