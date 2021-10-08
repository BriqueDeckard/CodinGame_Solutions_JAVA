// -----------------------------------------------------------------------
//  <copyright file="ProductAppService.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace POC_Prism.ApplicationService
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using POC_Prism.ApplicationService.Contract;
    using POC_Prism.Domain;
    using POC_Prism.Infrastructure.data.UnitOfWork;

    /// <summary>
    /// Application service for product entity.
    /// </summary>
    internal class ProductAppService : IProductAppService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductAppService"/> class.
        /// </summary>
        public ProductAppService(IRepository repository)
        {
            this._repository = repository;
        }

        /// <summary>
        /// Searches the specified search text.
        /// </summary>
        /// <param name="searchText">The search text.</param>
        /// <returns></returns>
        public IList<ProductSearchDto> Search(string searchText)
        {
            var results = this._repository.GetByFilter<Product, string, ProductSelectResult>(
                     ProductSelectBuilder.ProductSearchSelect(),
                    ProductSpecification.Search(searchText, true),
                     o => o.Reference,
                    true);

            return results.Select(ProductFactory.CreateSearchDto).ToList();
        }

        /// <summary>
        /// The repository
        /// </summary>
        private readonly IRepository _repository;
    }
}