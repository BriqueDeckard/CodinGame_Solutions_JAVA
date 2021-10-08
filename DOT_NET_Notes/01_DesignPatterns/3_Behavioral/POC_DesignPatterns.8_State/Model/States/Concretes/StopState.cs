namespace POC_DesignPatterns._8_State.Model.States.Concretes
{
    using POC_DesignPatterns._8_State.Model.Context;

    /// <summary>
    /// StopState class.
    /// </summary>
    /// <seealso cref="ConcreteState" />
    public class StopState : ConcreteState
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StopState"/> class.
        /// </summary>
        /// <param name="title">The title.</param>
        public StopState(string title) : base(title)
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