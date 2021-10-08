// -----------------------------------------------------------------------
//  <copyright file="SampleDatabaseSettings.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace DDDMicroservice.Domain
{
    /// <summary>
    /// Settings class for SampleDatabase.
    /// Used to store the appsettings.json file's SampleDatabaseSettings property values.
    /// </summary>
    /// <seealso cref="ISampleDatabaseSettings" />
    public class SampleDatabaseSettings : ISampleDatabaseSettings
    {
        /// <summary>
        /// Gets or sets the connection string.
        /// </summary>
        /// <value>
        /// The connection string.
        /// </value>
        public string ConnectionString { get; set; }

        /// <summary>
        /// Gets or sets the name of the database.
        /// </summary>
        /// <value>
        /// The name of the database.
        /// </value>
        public string DatabaseName { get; set; }

        /// <summary>
        /// Gets or sets the name of the sample collection.
        /// </summary>
        /// <value>
        /// The name of the sample collection.
        /// </value>
        public string SampleCollectionName { get; set; }
    }
}