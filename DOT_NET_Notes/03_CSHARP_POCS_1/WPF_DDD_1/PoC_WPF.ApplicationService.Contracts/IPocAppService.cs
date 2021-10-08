// -----------------------------------------------------------------------
//  <copyright file="IPocAppService.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace PoC_WPF.ApplicationServices.Contracts
{
    using PoC_WPF.Domain.Aggregates;

    //TODO : WPF 6.1 Create Application service interface.
    /// <summary>
    /// Interface for application service
    /// </summary>
    public interface IPocAppService
    {
        /// <summary>
        /// Adds this object.
        /// </summary>
        EntityClass Add();

        EntityClass Get(int id);
    }
}