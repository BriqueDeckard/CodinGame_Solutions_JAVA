// -----------------------------------------------------------------------
//  <copyright file="ProductPrice.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace POC_Prism.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Class for product price.
    /// </summary>
    public class ProductPrice
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the price excluding vat.
        /// </summary>
        /// <value>
        /// The price excluding vat.
        /// </value>
        public double PriceExcludingVaT { get; set; }

        /// <summary>
        /// Gets or sets the vat identifier.
        /// </summary>
        /// <value>
        /// The vat identifier.
        /// </value>
        public int VaTId { get; set; }

        #region - - - - Navigation Properties ----

        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        /// <value>
        /// The created date.
        /// </value>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the product.
        /// </summary>
        /// <value>
        /// The product.
        /// </value>
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        /// <summary>
        /// Gets or sets the product identifier.
        /// </summary>
        /// <value>
        /// The product identifier.
        /// </value>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets the reference.
        /// </summary>
        /// <value>
        /// The reference.
        /// </value>
        [StringLength(20)]
        public string Reference { get; set; }

        #endregion
    }
}