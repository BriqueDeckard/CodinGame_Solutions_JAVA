// -----------------------------------------------------------------------
//  <copyright file="NotificationMockRepository.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace Cassandia.Notification.Tests
{
    using Cassandia.Notification.Domain.Aggregates;
    using Cassandia.Notification.Infrastructure.Data;
    using Cassandia.Tests.Core;

    public class NotificationMockRepository : MockRepository<CassandiaNotification>, INotificationRepository
    {
        public bool Push(CassandiaNotification entity)
        {
            return true;
        }
    }
}