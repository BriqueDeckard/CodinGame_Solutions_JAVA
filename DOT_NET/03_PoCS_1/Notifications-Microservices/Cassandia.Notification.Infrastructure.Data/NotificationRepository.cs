//-----------------------------------------------------------------------
// <copyright file="NotificationRepository.cs" company="Modis">
//     Copyright © 2019 . All rights reserved
// </copyright>
//-----------------------------------------------------------------------

namespace Cassandia.Notification.Infrastructure.Data
{
    using Cassandia.Notification.Infrastructure.Data.Serializer;
    using Cassandia.Notification.ApplicationService.Contract;
    using Cassandia.Notification.Domain.Aggregates;
    using Cassandia.Infrastructure.Data.Core.MongoDB;
    using System;
    using System.IO;
    using System.Net;
    using System.Text;
    using Cassandia.Notification.Infrastructure.Data.Configuration;

    /// <summary>
    /// Repository to handle request on microservice main entity
    /// </summary>
    public class NotificationRepository : MongoDbRepositoryBase<Domain.Aggregates.CassandiaNotification>, INotificationRepository
    {
        public NotificationRepository(ISerializer serializer)
        {
            this._serializer = serializer;
        }

        /// <summary>
        /// Pushes the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        public string PushToTopic(CassandiaNotification entity)
        {
            //Gets the message
            IFirebaseMessage entityMessage = entity.Message;

            //Insert the entity
            CassandiaNotification returnValue = this.Insert(entity);

            //PushToTopic the notification
            string result = this.PushMessage(entityMessage);

            // return ((!string.IsNullOrEmpty(result)) && (null != returnValue));
            return result;
        }

        /// <summary>
        /// The settings
        /// </summary>
        private readonly NotificationSettings _settings = ConfigurationManager.NotificationSettings;

        /// <summary>
        /// The serializer
        /// </summary>
        private ISerializer _serializer;

        /// <summary>
        /// Gets the web request from settings.
        /// </summary>
        /// <param name="byteArray">The byte array.</param>
        /// <returns></returns>
        private WebRequest GetWebRequestFromSettings(Byte[] byteArray)
        {
            //Create a web request with the FCM uri.
            WebRequest tRequest = WebRequest.Create(_settings.FirebaseCloudMessagingUri);

            //Specify the Http method.
            tRequest.Method = "post";

            //Specify the authorization key with the fcm server key.
            tRequest.Headers.Add(string.Format(_settings.AuthorizationHeaderName));

            //Specify the sender ID.
            tRequest.Headers.Add(string.Format(_settings.SenderHeader, _settings.SenderId));

            //Specify the size of the entity-body.
            tRequest.ContentLength = byteArray.Length;

            //Specify the content type (Json).
            tRequest.ContentType = _settings.RequestContentType;

            return tRequest;
        }

        /// <summary>
        /// Pushes a notification entity.
        /// </summary>
        /// <param name="entity">
        /// The entity.
        /// </param>
        /// <returns></returns>
        private string PushMessage(IFirebaseMessage message)
        {
            String sResponseFromServer = "";

            string json = this._serializer.MessageToJson(message);

            byte[] byteArray = Encoding.UTF8.GetBytes(json);

            //Get the web request from that array.
            WebRequest webRequest = this.GetWebRequestFromSettings(byteArray);

            try
            {
                //use a stream for writing data to the Internet resource.
                using (Stream dataStream = webRequest.GetRequestStream())
                {
                    dataStream.Write(byteArray, 0, byteArray.Length);
                    //use a web response that returns a response the request.
                    using (WebResponse tResponse = webRequest.GetResponse())
                    {
                        //Use a stream that returns the data stream from the response.
                        using (Stream dataStreamResponse = tResponse.GetResponseStream())
                        {
                            if (dataStreamResponse != null)
                            {
                                //Use a stream reader to read the response
                                using (StreamReader tReader = new StreamReader(dataStreamResponse))
                                {
                                    sResponseFromServer = tReader.ReadToEnd();
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                return string.Empty;
            }
            return "Response = " + sResponseFromServer + "\n" + "JSON = " + json;
        }
    }
}