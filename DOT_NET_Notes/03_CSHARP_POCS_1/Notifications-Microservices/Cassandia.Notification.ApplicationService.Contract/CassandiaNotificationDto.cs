//-----------------------------------------------------------------------
// <copyright file="NotificationDto.cs" company="Modis">
//     Copyright © 2019 . All rights reserved
// </copyright>
//-----------------------------------------------------------------------

namespace Cassandia.Notification.ApplicationService.Contract
{
    using System.Collections.Generic;
    using Cassandia.ApplicationService.Contract.Core;

    /// <summary>
    /// Main Microservice Dto
    /// </summary>
    /// <seealso cref="Cassandia.ApplicationService.Contract.Core.IDto{System.String}" />
    public class CassandiaNotificationDto : IDto<string>
    {
        /// <summary>
        /// Identifier
        /// </summary>
        public string Id { get; set; } = "";

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        public FirebaseMessageDto Message { get; set; }

        /// <summary>
        /// Gets or sets the topic.
        /// </summary>
        /// <value>
        /// The topic.
        /// </value>
        public string Topic { get; set; } = "";
    }
}