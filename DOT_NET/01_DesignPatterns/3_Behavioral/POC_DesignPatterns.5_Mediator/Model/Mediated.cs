namespace POC_DesignPatterns._5_Mediator
{
    using System;

    /// <summary>
    /// Mediated class.
    /// </summary>
    public class Mediated
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Mediated"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        public Mediated(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        /// <summary>
        /// Does the input operation.
        /// </summary>
        /// <param name="data">The data.</param>
        public void DoInputOperation(string data)
        {
            Console.WriteLine("Operation done by " + Name + " : \t " + data);
        }

        /// <summary>
        /// Does the output operation.
        /// </summary>
        /// <param name="recipient">The recipient.</param>
        /// <param name="data">The data.</param>
        public void DoOutputOperation(Mediated recipient, string data)
        {
            Mediator.DoMediation(this, recipient, data);
        }

        /// <summary>
        /// The name
        /// </summary>
        private string _name;
    }
}