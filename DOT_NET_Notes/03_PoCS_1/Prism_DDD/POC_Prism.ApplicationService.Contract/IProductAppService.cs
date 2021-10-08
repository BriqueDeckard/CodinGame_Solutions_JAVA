// -----------------------------------------------------------------------
//  <copyright file="IProductAppService.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace POC_Prism.ApplicationService.Contract
{
    using System.Collections.Generic;

    /// <summary>
    /// Interface for ProductAppService
    /// </summary>
    public interface IProductAppService
    {
        /// <summary>
        /// Searches the specified search text.
        /// </summary>
        /// <param name="searchText">The search text.</param>
        /// <returns></returns>
        IList<ProductSearchDto> Search(string searchText);
    }
}