// -----------------------------------------------------------------------
//  <copyright file="NotificationController.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------
namespace Cassandia.Notification.ApiKafka
{
    using Cassandia.ApplicationService.Contract.Core;
    using Cassandia.Kafka.Api;
    using Cassandia.Kafka.Net.Attributes;
    using Cassandia.Kafka.Services;
    using Cassandia.Logging;
    using global::Kafka.Services;
    using Cassandia.Notification.ApplicationService.Contract;
    using Cassandia.Kafka.Net;

    [KafkaController("notification")]
    internal class NotificationController : CoreControllerBase<CassandiaNotificationDto, NotificationParameter, NotificationParameterDto, string>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationController"/> class.
        /// </summary>
        /// <param name="parameterConverter">
        /// The parameter converter.
        /// </param>
        /// <param name="coreApplicationService">
        /// The core application service.
        /// </param>
        /// <param name="logger">
        /// The logger.
        /// </param>
        /// <param name="consumer">
        /// The consumer.
        /// </param>
        /// <param name="producer">
        /// The producer.
        /// </param>
        public NotificationController(IKafkaParameterConverter<NotificationParameter, NotificationParameterDto> parameterConverter, ICoreApplicationService<CassandiaNotificationDto, NotificationParameterDto, string> coreApplicationService, ICassandiaLogger logger, IKafkaConsumer consumer, IKafkaProducer producer) : base(parameterConverter, coreApplicationService, logger, consumer, producer)
        {
        }

        /// <summary>
        /// Pushes the specified dto.
        /// </summary>
        /// <param name="dto">
        /// The dto.
        /// </param>
        /// <returns></returns>
        [KafkaPost(route: "push/{notificationDto}", identifier: "push")]
        public KafkaNetMessage Push(CassandiaNotificationDto dto)
        {
            string result = this._notificationApplicationService.PushToTopic(dto);

            if (!string.IsNullOrEmpty(result))
                return this.Ok(true);
            return this.BadRequest();
        }

        /// <summary>
        /// The notification application service
        /// </summary>
        private readonly INotificationApplicationService _notificationApplicationService;
    }
}