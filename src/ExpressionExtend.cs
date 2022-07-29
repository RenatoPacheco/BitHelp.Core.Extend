using System;
using System.Linq;
using System.Reflection;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace BitHelp.Core.Extend
{
    public static class ExpressionExtend
    {
        public static MemberExpression MemberExpression(this Expression expression)
        {
            if (expression is UnaryExpression unary)
            {
                return ((MemberExpression)unary.Operand);
            }

            return ((MemberExpression)expression);
        }

        public static MemberExpression MemberExpression<T, P>(this Expression<Func<T, P>> expression)
        {
            return expression.Body.MemberExpression();
        }

        public static PropertyInfo PropertyInfo<T, P>(this Expression<Func<T, P>> expression)
        {
            return (PropertyInfo)expression.MemberExpression().Member;
        }

        public static string PropertyName<T, P>(this Expression<Func<T, P>> expression)
        {
            return expression.PropertyInfo().Name;
        }

        public static string PropertyName(this Expression expression)
        {
            return expression.MemberExpression().Member.Name;
        }

        public static Type PropertyType<T, P>(this Expression<Func<T, P>> expression)
        {
            return expression.PropertyInfo().PropertyType;
        }

        public static string PropertyDisplay<T, P>(this Expression<Func<T, P>> expression)
        {
            return expression.PropertyInfo().PropertyDisplay();
        }

        public static string PropertyDescription<T, P>(this Expression<Func<T, P>> expression)
        {
            return expression.PropertyInfo().PropertyDescription();
        }

        [Obsolete("Use PropertyPath")]
        public static string PropertyTrail<T, P>(this Expression<Func<T, P>> expression)
        {
            return expression.PropertyPath();
        }

        public static string PropertyPath<T, P>(this Expression<Func<T, P>> expression)
        {
            string result = expression.MemberExpression().ToString();
            return Regex.Replace(result, @"^[^\.]+\.|\)+$", "");
        }

        public static Expression<Action<T, P>> CreateSetter<T, P>(this Expression<Func<T, P>> expression)
        {
            ParameterExpression valueParam = Expression.Parameter(typeof(P));
            BinaryExpression body = Expression.Assign(expression.Body, valueParam);
            return Expression.Lambda<Action<T, P>>(body,
                expression.Parameters.Single(),
                valueParam);
        }
    }
}
