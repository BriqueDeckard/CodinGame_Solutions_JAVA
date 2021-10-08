namespace POC_DesignPatterns._1_ChainOfResponsability.Handler
{
    using System;

    /// <summary>
    /// Abstract handler.
    /// </summary>
    public abstract class AbstractHandler
    {
        /// <summary>
        /// Gets or sets the successor.
        /// </summary>
        /// <value>
        /// The successor.
        /// </value>
        /// <exception cref="System.NullReferenceException"></exception>
        public AbstractHandler Successor
        {
            get
            {
                if (this._successor == null)
                {
                    throw new NullReferenceException();
                }
                else
                {
                    return this._successor;
                }
            }
            set => _successor = value;
        }

        /// <summary>
        /// Handles the request.
        /// </summary>
        /// <param name="request">The request.</param>
        public virtual void HandleRequest(Request.Request request)
        {
            if (request.Value < this.Allowable)
            {
                Logger.Logger.Log(request.Name + " Approved");
                return;
            }
            else
            {
                Logger.Logger.Log(request.Name + " Reported");
                this.Successor.HandleRequest(request);
            }
        }

        /// <summary>
        /// The allowable
        /// </summary>
        protected int Allowable;

        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractHandler" /> class.
        /// </summary>
        /// <param name="successor">The successor.</param>
        protected AbstractHandler()
        {
        }

        /// <summary>
        /// The tag
        /// </summary>
        private const string TAG = "AbstractHandler ";

        /// <summary>
        /// The successor
        /// </summary>
        private AbstractHandler _successor;
    }
}