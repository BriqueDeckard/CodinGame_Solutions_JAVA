// -----------------------------------------------------------------------
//  <copyright file="SampleObjectValue.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace DDDMicroservice.Domain.ObjectValue
{
    /// <summary>
    /// Sample object value.
    /// </summary>
    public class SampleObjectValue
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleObjectValue"/> class.
        /// </summary>
        /// <param name="stringProperty">The string property.</param>
        public SampleObjectValue(string stringProperty)
        {
            StringProperty = stringProperty;
        }

        /// <summary>
        /// Gets or sets the string property.
        /// </summary>
        /// <value>
        /// The string property.
        /// </value>
        public string StringProperty { get => _stringProperty; set => _stringProperty = value; }

        /// <summary>
        /// The string property
        /// </summary>
        private string _stringProperty;
    }
}