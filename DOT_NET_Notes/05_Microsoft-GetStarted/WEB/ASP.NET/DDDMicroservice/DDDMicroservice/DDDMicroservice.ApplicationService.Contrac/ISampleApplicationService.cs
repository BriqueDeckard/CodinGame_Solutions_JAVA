// -----------------------------------------------------------------------
//  <copyright file="ISampleApplicationService.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace DDDMicroservice.ApplicationService.Contract
{
    using System.Collections.Generic;

    /// <summary>
    /// Interface for SampleApplicationService.
    /// </summary>
    public interface ISampleApplicationService
    {
        /// <summary>
        /// Adds the specified dto.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <returns></returns>
        SampleEntityDto Add(SampleEntityDto dto);

        /// <summary>
        /// Deletes the specified dto.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <returns></returns>
        SampleEntityDto Delete(SampleEntityDto dto);

        /// <summary>
        /// Deletes the specified di.
        /// </summary>
        /// <param name="di">The di.</param>
        /// <returns></returns>
        string Delete(string di);

        /// <summary>
        /// Searches the specified search text.
        /// </summary>
        /// <param name="searchText">The search text.</param>
        /// <returns></returns>
        SampleEntityDto Search(string searchText);

        /// <summary>
        /// Searches this instance.
        /// </summary>
        /// <returns></returns>
        IEnumerable<SampleEntityDto> Search();
    }
}