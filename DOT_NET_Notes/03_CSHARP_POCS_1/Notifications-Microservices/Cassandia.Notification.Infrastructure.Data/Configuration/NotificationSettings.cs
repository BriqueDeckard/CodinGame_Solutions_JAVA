// -----------------------------------------------------------------------
//  <copyright file="NotificationSettings.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace Cassandia.Notification.Infrastructure.Data.Configuration
{
    /// <summary>
    /// Settings for notification micro-services
    /// </summary>
    public class NotificationSettings
    {
        /// <summary>
        /// The authorization header name
        /// </summary>
        public string AuthorizationHeaderName { get; set; }

        /// <summary>
        /// The firebase cloud messaging URI
        /// </summary>
        public string FirebaseCloudMessagingUri { get; set; }

        /// <summary>
        /// The request content type
        /// </summary>
        public string RequestContentType { get; set; }

        /// <summary>
        /// The sender header
        /// </summary>
        public string SenderHeader { get; set; }

        /// <summary>
        /// The sender identifier
        /// </summary>
        public string SenderId { get; set; }
    }
}