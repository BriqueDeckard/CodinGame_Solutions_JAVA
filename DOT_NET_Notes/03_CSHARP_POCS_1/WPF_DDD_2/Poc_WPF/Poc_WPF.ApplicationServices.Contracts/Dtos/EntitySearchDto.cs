// -----------------------------------------------------------------------
//  <copyright file="EntitySearchDto.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace Poc_WPF.ApplicationServices.Contracts.Dtos
{
    /// <summary>
    /// Dto for entity search.
    /// </summary>
    public class EntitySearchDto
    {
        /// <summary>
        /// Gets or sets the body.
        /// </summary>
        /// <value>
        /// The body.
        /// </value>
        public string Body { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }
    }
}