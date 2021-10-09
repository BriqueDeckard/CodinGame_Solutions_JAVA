// -----------------------------------------------------------------------
//  <copyright file="SampleEntityDTO.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace DDDMicroservice.ApplicationService.Contract
{
    /// <summary>
    /// Sample entity Dto class.
    /// </summary>
    public class SampleEntityDto
    {
        /// <summary>
        /// Gets or sets a value indicating whether [boolean property].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [boolean property]; otherwise, <c>false</c>.
        /// </value>
        public bool BooleanProperty { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the number property.
        /// </summary>
        /// <value>
        /// The number property.
        /// </value>
        public int NumberProperty { get; set; }

        /// <summary>
        /// Gets or sets the object value property.
        /// </summary>
        /// <value>
        /// The object value property.
        /// </value>
        public string ObjectValueProperty { get; set; }

        /// <summary>
        /// Gets or sets the string property.
        /// </summary>
        /// <value>
        /// The string property.
        /// </value>
        public string StringProperty { get; set; }
    }
}