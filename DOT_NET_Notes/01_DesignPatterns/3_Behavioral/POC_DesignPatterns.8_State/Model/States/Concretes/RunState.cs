namespace POC_DesignPatterns._8_State.Model.States.Concretes
{
    using POC_DesignPatterns._8_State.Model.Context;

    /// <summary>
    /// RunState class.
    /// </summary>
    /// <seealso cref="ConcreteState" />
    public class RunState : ConcreteState
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RunState"/> class.
        /// </summary>
        /// <param name="title">The title.</param>
        public RunState(string title) : base(title)
        {
        }

        /// <summary>
        /// Handles the specified context.
        /// </summary>
        /// <param name="context">The context.</param>
        public override void Handle(IContext context)
        {
            base.Handle(context);
            Logger.Logger.Log("STOP");
        }
    }
}