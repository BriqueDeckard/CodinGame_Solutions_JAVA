// -----------------------------------------------------------------------
//  <copyright file="Message.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace Cassandia.Notification.Domain.Aggregates
{
    using Cassandia.Notification.ApplicationService.Contract;

    /// <summary>
    /// The message to send. It encapsulates the Firebase notification.
    /// </summary>
    public class Message : IFirebaseMessage
    {
        /// <summary>
        /// Gets or sets a value indicating whether [content available].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [content available]; otherwise, <c>false</c>.
        /// </value>
        public bool content_available { get; set; } = true;

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public object data { get; set; }

        /// <summary>
        /// Gets or sets the notification.
        /// </summary>
        /// <value>
        /// The notification.
        /// </value>
        public IFirebaseNotification notification { get; set; }

        /// <summary>
        /// Gets or sets the priority.
        /// </summary>
        /// <value>
        /// The priority.
        /// </value>
        public string priority { get; set; } = "high";

        /// <summary>
        /// Gets or sets the recipients.
        /// </summary>
        /// <value>
        /// To.
        /// </value>
        public string to { get; set; }
    }
}