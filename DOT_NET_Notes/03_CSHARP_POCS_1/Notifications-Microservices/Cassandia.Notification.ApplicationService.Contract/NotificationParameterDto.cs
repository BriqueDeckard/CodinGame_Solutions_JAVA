//-----------------------------------------------------------------------
// <copyright file="NotificationParameterDto.cs" company="Modis">
//     Copyright © 2019 . All rights reserved
// </copyright>
//-----------------------------------------------------------------------

namespace Cassandia.Notification.ApplicationService.Contract
{
    using System.Collections.Generic;
    using Cassandia.ApplicationService.Contract.Core;

    /// <summary>
    /// A DTO containing converted params from URL QueryParams
    /// </summary>
    public class NotificationParameterDto : ParameterDtoBase
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the topic.
        /// </summary>
        /// <value>
        /// The topic.
        /// </value>
        public string Topic { get; set; }
    }
}