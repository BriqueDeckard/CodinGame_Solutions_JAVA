namespace POC_DesignPatterns._8_State.Model.States.Abstract
{
    using POC_DesignPatterns._8_State.Model.Context;

    /// <summary>
    /// IState interface.
    /// </summary>
    public interface IState
    {
        /// <summary>
        /// Handles the specified context.
        /// </summary>
        /// <param name="context">The context.</param>
        void Handle(IContext context);
    }
}