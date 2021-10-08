// -----------------------------------------------------------------------
//  <copyright file="NotificationParameterConverter.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace Cassandia.Notification.ApiKafka
{
    using Cassandia.Kafka.Api;
    using Cassandia.Notification.ApplicationService.Contract;

    /// <summary>
    /// Parameter converter for Notification micro-services.
    /// </summary>
    public class NotificationParameterConverter : IKafkaParameterConverter<NotificationParameter, NotificationParameterDto>
    {
        /// <summary>
        /// Converts the parameters.
        /// </summary>
        /// <param name="parameterBase">The parameter base.</param>
        /// <returns></returns>
        public NotificationParameterDto ConvertParameters(NotificationParameter parameterBase)
        {
            return new NotificationParameterDto()
            {
                DtoFormat = parameterBase.DtoFormat,
                Offset = parameterBase.Offset,
                PageIndex = parameterBase.PageIndex,
                PageSize = parameterBase.PageSize,
                SortBy = parameterBase.SortBy,
                Topic = parameterBase.Topic,
                Title = parameterBase.Title
            };
        }
    }
}