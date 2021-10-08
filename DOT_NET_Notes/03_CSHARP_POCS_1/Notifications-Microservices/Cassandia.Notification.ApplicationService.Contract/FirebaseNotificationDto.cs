// -----------------------------------------------------------------------
//  <copyright file="FirebaseNotificationDto.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace Cassandia.Notification.ApplicationService.Contract
{
    /// <summary>
    /// Dto for firebase notification.
    /// </summary>
    public class FirebaseNotificationDto
    {
        /// <summary>
        /// Gets or sets the body.
        /// </summary>
        /// <value>
        /// The body.
        /// </value>
        public string Body { get; set; }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title { get; set; }
    }
}