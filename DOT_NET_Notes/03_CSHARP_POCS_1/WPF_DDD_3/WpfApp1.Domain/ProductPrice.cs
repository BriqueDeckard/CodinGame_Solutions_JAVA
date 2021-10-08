// -----------------------------------------------------------------------
//  <copyright file="ProductPrice.cs" company="Azure Brain">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace WpfApp1.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// Product Price
    /// </summary>
    public class ProductPrice
    {
        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        /// <value>
        /// the created date.
        /// </value>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// the identifier.
        /// </value>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the price excluding vat.
        /// </summary>
        /// <value>
        /// the price excluding vat.
        /// </value>
        public double PriceExcludingVat { get; set; }

        /// <summary>
        /// Gets or sets the product identifier.
        /// </summary>
        /// <value>
        /// the product identifier.
        /// </value>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets the vat identifier.
        /// </summary>
        /// <value>
        /// the vat identifier.
        /// </value>
        public int VatId { get; set; }

        #region ---- Navigation Properties -----

        /// <summary>
        /// Gets or sets the product.
        /// </summary>
        /// <value>
        /// the product.
        /// </value>
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        #endregion
    }
}