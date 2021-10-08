// -----------------------------------------------------------------------
//  <copyright file="IEntity.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace PoC_WPF.Domain
{
    //TODO: WPF 5.1 Create the IEntity interface with an ID ;
    /// <summary>
    /// Interface for entity object.
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        int Id { get; set; }
    }
}