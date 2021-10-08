// -----------------------------------------------------------------------
//  <copyright file="Serializer.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace Cassandia.Notification.Infrastructure.Data.Serializer
{
    using Newtonsoft.Json;

    /// <summary>
    /// Newtonsoft serializer.
    /// </summary>
    public class Serializer : ISerializer
    {
        /// <summary>
        /// Gets the json.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="message">The message.</param>
        /// <returns></returns>
        public string MessageToJson<T>(T message)
        {
            JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };
            return JsonConvert.SerializeObject(message, Formatting.None, jsonSerializerSettings);
        }
    }
}