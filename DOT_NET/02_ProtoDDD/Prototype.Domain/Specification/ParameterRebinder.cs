using System.Collections.Generic;
using System.Linq.Expressions;

namespace Prototype.Domain.Specification
{
    public class ParameterRebinder : ExpressionVisitor
    {
        /// <summary>
        ///     The map.
        /// </summary>
        private readonly Dictionary<ParameterExpression, ParameterExpression> _map;

        /// <summary>
        ///     Initializes a new instance of the <see cref="ParameterRebinder" /> class.
        /// </summary>
        /// <param name="map">Map specification.</param>
        public ParameterRebinder(Dictionary<ParameterExpression, ParameterExpression> map)
        {
            _map = map ?? new Dictionary<ParameterExpression, ParameterExpression>();
        }

        /// <summary>
        ///     Replace parameters in expression with a Map information.
        /// </summary>
        /// <param name="map">Map information.</param>
        /// <param name="expression">Expression to replace parameters.</param>
        /// <returns>Expression with parameters replaced.</returns>
        public static Expression ReplaceParameters(Dictionary<ParameterExpression, ParameterExpression> map,
            Expression expression)
        {
            return new ParameterRebinder(map).Visit(expression);
        }

        /// <summary>
        ///     Visit pattern method.
        /// </summary>
        /// <param name="p">A Parameter expression.</param>
        /// <returns>New visited expression.</returns>
        protected override Expression VisitParameter(ParameterExpression p)
        {
            if (_map.TryGetValue(p, out var replacement)) p = replacement;

            return base.VisitParameter(p);
        }
    }
}