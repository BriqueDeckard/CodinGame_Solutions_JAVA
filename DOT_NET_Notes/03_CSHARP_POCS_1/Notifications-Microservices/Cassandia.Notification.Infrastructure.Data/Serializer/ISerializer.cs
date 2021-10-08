// -----------------------------------------------------------------------
//  <copyright file="ISerializer.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace Cassandia.Notification.Infrastructure.Data.Serializer
{
    /// <summary>
    /// Interface for Firebase notification serializer.
    /// </summary>
    public interface ISerializer
    {
        /// <summary>
        /// Messages to json.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="message">The message.</param>
        /// <returns></returns>
        string MessageToJson<T>(T message);
    }
}