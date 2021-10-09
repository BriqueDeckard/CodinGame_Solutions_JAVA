//-----------------------------------------------------------------------
// <copyright file="NotificationParameterConverter.cs" company="Modis">
//     Copyright © 2019 . All rights reserved
// </copyright>
//-----------------------------------------------------------------------

namespace Cassandia.Notification.Api
{
    using Cassandia.Api.Core.Converters;
    using Cassandia.Notification.ApplicationService.Contract;

    /// <summary>
    /// Parameter converter for Notification entity
    /// </summary>
    public class NotificationParameterConverter : IParameterConverter<NotificationParameter, NotificationParameterDto>
    {
        /// <summary>
        /// Converts parameters from query params to the associated DTO
        /// </summary>
        /// <param name="parameterBase">
        /// Parameters from Query Params
        /// </param>
        /// <returns>
        /// A Parameter DTO
        /// </returns>
        public NotificationParameterDto ConvertParameters(NotificationParameter parameterBase)
        {
            return new NotificationParameterDto
            {
                Title = parameterBase.Title
            };
        }
    }
}