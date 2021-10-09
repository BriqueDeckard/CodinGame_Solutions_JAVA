//-----------------------------------------------------------------------
// <copyright file="NotificationApplicationService.cs" company="Modis">
//     Copyright © 2019 . All rights reserved
// </copyright>
//-----------------------------------------------------------------------

namespace Cassandia.Notification.ApplicationService
{
    using Cassandia.Infrastructure.Data.Core;
    using Cassandia.Notification.Infrastructure.Data;
    using Cassandia.ApplicationService.Contract.Core.Mappers;
    using Cassandia.ApplicationService.Core;
    using Cassandia.Domain.Core.Factories;
    using Cassandia.Domain.Core.Specification;
    using Contract;
    using Domain.Aggregates;

    using System.Collections.Generic;

    /// <summary>
    /// Application Service for main microservice entity
    /// </summary>
    public class NotificationApplicationService : CoreApplicationServiceBase<CassandiaNotificationDto, NotificationParameterDto, CassandiaNotification, string>, INotificationApplicationService
    {
        /// <summary>
        /// Public constructor to instanciate application service
        /// </summary>
        /// <param name="repository">Repository to access database operations</param>
        /// <param name="factory">Factory to manage Entities and Dto conversions</param>
        /// <param name="businessSpecification">Specification for business logic</param>
        /// <param name="mapper">Mapper to return specific Dtos.</param>
        /// <param name="notificationRepository">The notification repository.</param>
        public NotificationApplicationService(
            IObjectRepository<Domain.Aggregates.CassandiaNotification> repository,
            IFactory<Domain.Aggregates.CassandiaNotification, CassandiaNotificationDto, string> factory,
            IBusinessSpecification<Domain.Aggregates.CassandiaNotification, NotificationParameterDto, string> businessSpecification,
            IMapper<Domain.Aggregates.CassandiaNotification> mapper,
            INotificationRepository notificationRepository) :
            base(repository, factory, businessSpecification, mapper)
        {
            this._notificationRepository = notificationRepository;
        }

        /// <summary>
        /// Posts the specified notification dto.
        /// </summary>
        /// <param name="notificationDto">
        /// The notification dto.
        /// </param>
        /// <param name="topic">
        /// The topic.
        /// </param>
        /// <returns></returns>
        public string PushToTopic(CassandiaNotificationDto dto)
        {
            return this._notificationRepository.PushToTopic(this.Factory.DtoToEntity(dto));
        }

        /// <summary>
        /// The notification repository
        /// </summary>
        private readonly INotificationRepository _notificationRepository;
    }
}