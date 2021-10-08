namespace POC_DesignPatterns._3_Interpreter.Concretes
{
    using _3_Interpreter.Abstracts;

    using System;

    /// <summary>
    /// Number class.
    /// </summary>
    /// <seealso cref="AbstractExpression" />
    public class Number : AbstractExpression
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Number"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <exception cref="System.ArgumentException"></exception>
        public Number(string value)
        {
            switch (value)
            {
                case "one": this._value = 1; break;
                case "two": this._value = 2; break;
                case "three": this._value = 3; break;
                case "four": this._value = 4; break;
                case "five": this._value = 5; break;
                case "six": this._value = 6; break;
                case "seven": this._value = 7; break;
                case "eight": this._value = 8; break;
                case "nine": this._value = 9; break;
                default: throw new ArgumentException();
            }
        }

        /// <summary>
        /// Interprets this instance.
        /// </summary>
        /// <returns></returns>
        public override int Interpret()
        {
            return this._value;
        }

        /// <summary>
        /// The value
        /// </summary>
        private int _value;
    }
}