// -----------------------------------------------------------------------
//  <copyright file="NotificationParameter.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------
namespace Cassandia.Notification.ApiKafka
{
    using Cassandia.Kafka.Api;

    /// <summary>
    /// Parameter for search.
    /// </summary>
    /// <seealso cref="Cassandia.Kafka.Api.KafkaParameterBase" />
    public class NotificationParameter : KafkaParameterBase
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