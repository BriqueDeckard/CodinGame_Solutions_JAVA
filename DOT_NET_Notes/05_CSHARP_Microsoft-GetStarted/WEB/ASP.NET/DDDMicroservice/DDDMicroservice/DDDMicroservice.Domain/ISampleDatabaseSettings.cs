// -----------------------------------------------------------------------
//  <copyright file="ISampleDatabaseSettings.cs" company="Modis">
//   Copyright © 2019 . All rights reserved
//  </copyright>
//  -----------------------------------------------------------------------

namespace DDDMicroservice.Domain
{
    /// <summary>
    /// Interface for Sample Database Settings.
    /// </summary>
    public interface ISampleDatabaseSettings
    {
        /// <summary>
        /// Gets or sets the connection string.
        /// </summary>
        /// <value>
        /// The connection string.
        /// </value>
        string ConnectionString { get; set; }

        /// <summary>
        /// Gets or sets the name of the database.
        /// </summary>
        /// <value>
        /// The name of the database.
        /// </value>
        string DatabaseName { get; set; }

        /// <summary>
        /// Gets or sets the name of the sample collection.
        /// </summary>
        /// <value>
        /// The name of the sample collection.
        /// </value>
        string SampleCollectionName { get; set; }
    }
}