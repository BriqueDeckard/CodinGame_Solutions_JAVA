//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Modis">
//     Copyright © 2019 . All rights reserved
// </copyright>
//-----------------------------------------------------------------------

namespace Cassandia.Notification.Api
{
    using System.Collections.Generic;
    using Cassandia.Api.Core;

    /// <summary>
    /// Parameters received from query params
    /// </summary>
    public class NotificationParameter : ParameterBase
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