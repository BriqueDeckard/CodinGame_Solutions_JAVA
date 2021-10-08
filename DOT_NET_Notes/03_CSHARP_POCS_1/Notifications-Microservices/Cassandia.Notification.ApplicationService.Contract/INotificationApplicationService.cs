//-----------------------------------------------------------------------
// <copyright file="INotificationApplicationService.cs" company="Modis">
//     Copyright © 2019 . All rights reserved
// </copyright>
//-----------------------------------------------------------------------

namespace Cassandia.Notification.ApplicationService.Contract
{
    using System.Collections.Generic;

    /// <summary>
    /// Microservice specific application service
    /// </summary>
    public interface INotificationApplicationService
    {
        /// <summary>
        /// Pushes the specified notification dto.
        /// </summary>
        /// <param name="notificationDto">The notification dto.</param>
        /// <param name="topic">The topic.</param>
        /// <returns></returns>
        string PushToTopic(CassandiaNotificationDto dto);
    }
}