using System;
using System.Linq;
using System.Reflection;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BitHelp.Core.Extend
{
    public static class ExpressionExtend
    {
        public static MemberExpression MemberExpression(this Expression expression)
        {
            if (expression is UnaryExpression unary)
                return ((MemberExpression)unary.Operand);

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
            DisplayAttribute display;
            PropertyInfo property = expression.PropertyInfo();
            string result = property.Name;

            display = (DisplayAttribute)property.GetCustomAttributes(typeof(DisplayAttribute), false)?.FirstOrDefault();
            result = display?.Name ?? result;

            return result;
        }

        public static string PropertyDescription<T, P>(this Expression<Func<T, P>> expression)
        {
            PropertyInfo property = expression.PropertyInfo();
            DescriptionAttribute display;
            string result;

            display = (DescriptionAttribute)property.GetCustomAttributes(typeof(DescriptionAttribute), false)?.FirstOrDefault();
            result = display?.Description;

            return result;
        }

        public static string PropertyTrail<T, P>(this Expression<Func<T, P>> expression)
        {
            string result = expression.MemberExpression().ToString();
            return Regex.Replace(result, @"^[^\.]+\.|\)+$", "");
        }
    }
}
