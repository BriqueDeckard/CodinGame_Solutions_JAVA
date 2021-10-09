// --------------------------------------------------------------------
// <copyright file="ParametersRebinder.cs" company="Modis">
//     Copyright (c) . All rights reserved.
// </copyright>
// --------------------------------------------------------------------

namespace  POC_Prism.Domain.Specification
{
    using System.Collections.Generic;
    using System.Linq.Expressions;

    /// <summary>
    /// Helper for binder parameters without use Invoke method in expressions (this methods is not supported in all LINQ query providers, for example
    /// in Linq2Entities is not supported).
    /// </summary>
    public sealed class ParameterRebinder : ExpressionVisitor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParameterRebinder"/> class.
        /// </summary>
        /// <param name="map">Map specification.</param>
        public ParameterRebinder(Dictionary<ParameterExpression, ParameterExpression> map)
        {
            this._map = map ?? new Dictionary<ParameterExpression, ParameterExpression>();
        }

        /// <summary>
        /// Replace parameters in expression with a Map information.
        /// </summary>
        /// <param name="map">Map information.</param>
        /// <param name="expression">Expression to replace parameters.</param>
        /// <returns>Expression with parameters replaced.</returns>
        public static Expression ReplaceParameters(Dictionary<ParameterExpression, ParameterExpression> map, Expression expression)
        {
            return new ParameterRebinder(map).Visit(expression);
        }

        /// <summary>
        /// Visit pattern method.
        /// </summary>
        /// <param name="p">A Parameter expression.</param>
        /// <returns>New visited expression.</returns>
        protected override Expression VisitParameter(ParameterExpression p)
        {
            if (this._map.TryGetValue(p, out ParameterExpression replacement))
            {
                p = replacement;
            }

            return base.VisitParameter(p);
        }

        /// <summary>
        /// The map.
        /// </summary>
        private readonly Dictionary<ParameterExpression, ParameterExpression> _map;
    }
}