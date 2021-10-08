using System;
using System.Linq.Expressions;
using Prototype.Domain.AggregatesModel.SampleEntityAggregate;

namespace Prototype.Domain.SelectBuilders
{
    /// <summary>
    ///     The main intention of the builder is to create complex objects by separating the construction process from its
    ///     representation.
    /// </summary>
    public class SampleEntitySelectBuilder
    {
        /// <summary>
        ///     Samples entity search selection.
        /// </summary>
        /// <returns></returns>
        public static Expression<Func<SampleEntity, SampleEntitySelectResult>> SampleEntitySearchSelection()
        {
            return s => new SampleEntitySelectResult
            {
                Id = s.Id,
                StringValue = s.StringValue
            };
        }
    }
}