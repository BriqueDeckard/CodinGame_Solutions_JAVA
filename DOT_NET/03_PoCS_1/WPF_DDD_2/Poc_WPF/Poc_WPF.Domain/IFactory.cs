// -----------------------------------------------------------------------
//  <copyright file="IFactory.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace Poc_WPF.ApplicationServices.Contracts
{
    using Poc_WPF.Domain;

    public interface IFactory
    {
        /// <summary>
        /// Dtoes to entity.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <returns></returns>
        Entity DtoToEntity(EntityDto dto);

        /// <summary>
        /// Entities to dto.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        EntityDto EntityToDto(Entity entity);
    }
}