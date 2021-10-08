// -----------------------------------------------------------------------
//  <copyright file="ProductFactory.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace POC_Prism.Domain
{
    using System;
    using POC_Prism.ApplicationService.Contract;

    /// <summary>
    /// Factory class for product.
    /// </summary>
    public static class ProductFactory
    {
        /// <summary>
        /// Creates the search dto.
        /// </summary>
        /// <param name="selectResult">The select result.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException">selectResult</exception>
        public static ProductSearchDto CreateSearchDto(ProductSelectResult selectResult)
        {
            if (selectResult == null)
            {
                throw new ArgumentNullException(nameof(selectResult));
            }

            return new ProductSearchDto()
            {
                Id = selectResult.Id,
                Name = $"{selectResult.Reference} - {selectResult.Name} - {selectResult.Price}"
            };
        }
    }
}