// -----------------------------------------------------------------------
//  <copyright file="Product.cs" company="Azure Brain">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace WpfApp1.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Product
    {
        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        /// <value>
        /// the created date.
        /// </value>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// the description.
        /// </value>
        [StringLength(255)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// the identifier.
        /// </value>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is activated.
        /// </summary>
        /// <value>
        ///   <c>false</c>
        /// </value>
        public bool IsActivated { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// the name.
        /// </value>
        [StringLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the reference.
        /// </summary>
        /// <value>
        /// the reference.
        /// </value>
        [StringLength(10)]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>
        /// the weight.
        /// </value>
        public double? Weight { get; set; }

        #region ---- Navigation Properties -----

        /// <summary>
        /// Gets or sets the product prices.
        /// </summary>
        /// <value>
        /// the product prices.
        /// </value>
        public ICollection<ProductPrice> ProductPrices { get; set; }

        #endregion
    }
}