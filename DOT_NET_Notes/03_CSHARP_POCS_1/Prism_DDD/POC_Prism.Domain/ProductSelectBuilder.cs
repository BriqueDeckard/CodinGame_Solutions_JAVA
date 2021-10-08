// -----------------------------------------------------------------------
//  <copyright file="ProductSelectBuilder.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace POC_Prism.Domain
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;

    /// <summary>
    /// Select builder for product entity.
    /// </summary>
    public class ProductSelectBuilder
    {
        /// <summary>
        /// Products the search select.
        /// </summary>
        /// <returns></returns>
        public static Expression<Func<Product, ProductSelectResult>> ProductSearchSelect()
        {
            return s => new ProductSelectResult()
            {
                Id = s.Id,
                Name = s.Name,
                Reference = s.Reference,
                Price = s.ProductPrices.OrderBy(o => o.CreatedDate).FirstOrDefault().PriceExcludingVaT
            };
        }
    }
}