// -----------------------------------------------------------------------
//  <copyright file="Factory.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace Poc_WPF.Domain
{
    using System;
    using Poc_WPF.ApplicationServices.Contracts;

    public class Factory : IFactory
    {
        /// <summary>
        /// Dtoes to entity.
        /// </summary>
        /// <param name="dto">The dto.</param>
        /// <returns></returns>
        public Entity DtoToEntity(EntityDto dto)
        {
            if (dto == null)
            {
                throw new ArgumentNullException();
            }
            return new Entity { reference = dto.Reference, Body = dto.Body, Id = dto.Id, Title = dto.Title };
        }

        /// <summary>
        /// Entities to dto.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        public EntityDto EntityToDto(Entity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }

            return new EntityDto
            {
                Body = entity.Body,
                Id = entity.Id,
                Reference = entity.reference,
                Title = entity.Title
            };
        }
    }
}