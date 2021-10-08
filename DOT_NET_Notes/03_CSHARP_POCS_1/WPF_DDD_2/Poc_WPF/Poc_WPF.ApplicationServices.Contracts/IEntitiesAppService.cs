// -----------------------------------------------------------------------
//  <copyright file="IEntitiesAppService.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

using Poc_WPF.ApplicationServices.Contracts.Dtos;
using System.Collections.Generic;

namespace Poc_WPF.ApplicationServices.Contracts
{
    /// <summary>
    /// Interface for entities app service.
    /// </summary>
    public interface IEntitiesAppService
    {
        /// <summary>
        /// Adds the specified dto.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <returns></returns>
        bool Add(EntityDto dto);

        /// <summary>
        /// Searches the specified search text.
        /// </summary>
        /// <param name="searchText">The search text.</param>
        /// <returns></returns>
        IList<EntitySearchDto> Search(string searchText);
    }
}