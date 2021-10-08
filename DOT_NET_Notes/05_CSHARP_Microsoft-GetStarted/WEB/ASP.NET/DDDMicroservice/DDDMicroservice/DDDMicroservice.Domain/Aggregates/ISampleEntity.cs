// -----------------------------------------------------------------------
//  <copyright file="ISampleEntity.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace DDDMicroservice.Domain.Aggregates
{
    /// <summary>
    /// Interface for entities.
    /// </summary>
    public interface ISampleEntity
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        string Id { get; set; }
    }
}