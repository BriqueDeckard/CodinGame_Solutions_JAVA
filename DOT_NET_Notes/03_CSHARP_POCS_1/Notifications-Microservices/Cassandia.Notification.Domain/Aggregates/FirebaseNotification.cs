// -----------------------------------------------------------------------
//  <copyright file="Notification.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------
namespace Cassandia.Notification.Domain.Aggregates
{
    using Cassandia.Notification.ApplicationService.Contract;

    /// <summary>
    /// The notification to send.
    /// </summary>
    public class FirebaseNotification : IFirebaseNotification
    {
        /// <summary>
        /// Gets or sets the body.
        /// </summary>
        /// <value>
        /// The body.
        /// </value>
        public string body { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string title { get; set; }
    }
}