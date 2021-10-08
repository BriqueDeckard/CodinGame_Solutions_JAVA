// -----------------------------------------------------------------------
//  <copyright file="ProductSearchDto.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace POC_Prism.ApplicationService.Contract
{
    /// <summary>
    /// Dro for product search.
    /// </summary>
    public class ProductSearchDto
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }
    }
}