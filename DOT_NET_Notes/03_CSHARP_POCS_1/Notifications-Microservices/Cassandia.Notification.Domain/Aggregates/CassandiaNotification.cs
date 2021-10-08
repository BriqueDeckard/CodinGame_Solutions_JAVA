//-----------------------------------------------------------------------
// <copyright file="Notification.cs" company="Modis">
//     Copyright © 2019 . All rights reserved
// </copyright>
//-----------------------------------------------------------------------

namespace Cassandia.Notification.Domain.Aggregates
{
    using Cassandia.Notification.ApplicationService.Contract;

    using System.Collections.Generic;
    using Cassandia.Domain.Core.Entities;

    /// <summary>
    /// Notification to save
    /// </summary>
    /// <seealso cref="Cassandia.Domain.Core.Entities.IMongoEntity" />
    public class CassandiaNotification : IMongoEntity
    {
        /// <summary>
        /// Gets or sets the extra elements.
        /// </summary>
        /// <value>
        /// The extra elements.
        /// </value>
        /// <exception cref="System.NotImplementedException">
        /// </exception>
        public IDictionary<string, object> ExtraElements { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        /// <exception cref="System.NotImplementedException">
        /// </exception>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the message to send.
        /// </summary>
        /// <value>
        /// The notification.
        /// </value>
        public IFirebaseMessage Message { get; set; }
    }
}