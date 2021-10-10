using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01_SampleWebApi.models
{
    /// <summary>
    /// Model for the API.
    /// It is the representation of the resource that will
    /// be exposed to the clients.
    /// </summary>
    public class SuperHeroItem
    {
        /// <summary>
        /// The identifier.
        /// </summary>
        /// <value></value>
        public int Id { get; set; }

        /// <summary>
        /// The Name
        /// </summary>
        /// <value></value>
        public string Name { get; set; }
    }
}
