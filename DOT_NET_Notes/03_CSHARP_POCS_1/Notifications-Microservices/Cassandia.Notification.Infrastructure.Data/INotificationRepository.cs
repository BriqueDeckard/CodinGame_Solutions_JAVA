//-----------------------------------------------------------------------
// <copyright file="INotificationRepository.cs" company="Modis">
//     Copyright © 2019 . All rights reserved
// </copyright>
//-----------------------------------------------------------------------

namespace Cassandia.Notification.Infrastructure.Data
{
    using Cassandia.Notification.ApplicationService.Contract;

    using Domain.Aggregates;

    /// <summary>
    /// Interface for main Entity Repository methods
    /// </summary>
    public interface INotificationRepository
    {
        /// <summary>
        /// Pushes the specified entity.
        /// </summary>
        /// <param name="entity">
        /// The entity.
        /// </param>
        /// <returns></returns>
        string PushToTopic(CassandiaNotification entity);
    }
}