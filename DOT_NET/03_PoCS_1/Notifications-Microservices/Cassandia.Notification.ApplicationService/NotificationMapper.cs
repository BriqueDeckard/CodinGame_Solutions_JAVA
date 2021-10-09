//-----------------------------------------------------------------------
// <copyright file="NotificationMapper.cs" company="Modis">
//     Copyright © 2019 . All rights reserved
// </copyright>
//-----------------------------------------------------------------------

namespace Cassandia.Notification.ApplicationService
{
    using System;
    using System.Linq.Expressions;
    using Cassandia.ApplicationService.Contract.Core.Mappers;

    /// <summary>
    /// Mapping class to generate dtos from microservice entity.
    /// </summary>
    public class NotificationMapper : IMapper<Domain.Aggregates.CassandiaNotification>
    {
        /// <summary>
        /// Returns an expression to pass to the repository to map results with a specific DTO format.
        /// </summary>
        /// <param name="mappingType">
        /// Dto format to use
        /// </param>
        /// <returns>
        /// An expression associating an entity and a dto format
        /// </returns>
        /// <exception cref="ArgumentException">
        /// An exception is thrown when the mapping type is not handled by the method
        /// </exception>
        public Expression<Func<Domain.Aggregates.CassandiaNotification, object>> Map(string mappingType)
        {
            switch (mappingType.ToLower())
            {
                case "list":
                    return this.ListMap();

                default:
                    throw new ArgumentException($"{mappingType} is not a mapping type.");
            }
        }

        /// <summary>
        /// Lists to map.
        /// </summary>
        /// <returns></returns>
        private Expression<Func<Domain.Aggregates.CassandiaNotification, object>> ListMap()
        {
            return entity => new
            {
                Id = entity.Id,
                Message = entity.Message
            };
        }
    }
}