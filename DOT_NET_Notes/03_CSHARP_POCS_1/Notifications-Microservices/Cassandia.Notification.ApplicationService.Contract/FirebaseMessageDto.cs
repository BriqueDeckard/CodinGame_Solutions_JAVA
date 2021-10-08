// -----------------------------------------------------------------------
//  <copyright file="FirebaseMessageDto.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace Cassandia.Notification.ApplicationService.Contract
{
    /// <summary>
    /// Dto for firebase message
    /// </summary>
    public class FirebaseMessageDto
    {
        /// <summary>
        /// Gets or sets a value indicating whether [content available].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [content available]; otherwise, <c>false</c>.
        /// </value>
        public bool ContentAvailable { get; set; } = true;

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public object Data { get; set; }

        /// <summary>
        /// Gets or sets the notification.
        /// </summary>
        /// <value>
        /// The notification.
        /// </value>
        public FirebaseNotificationDto Notification { get; set; }

        /// <summary>
        /// Gets or sets the priority.
        /// </summary>
        /// <value>
        /// The priority.
        /// </value>
        public string Priority { get; set; } = "high";
    }
}