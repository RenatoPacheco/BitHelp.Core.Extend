﻿using System;
using System.Linq.Expressions;

namespace BitHelp.Core.Extend
{
    public static class ClassExtend
    {
        public static void PropertySetValue<T, P>(this T source, Expression<Func<T, P>> expression, P value)
            where T : class
        {
            var setterExpr = expression.CreateSetter();
            setterExpr.Compile()(source, value);
        }

        public static object PropertyGetValue<T, P>(this T source, Expression<Func<T, P>> expression)
            where T : class
        {
            return expression.Compile().DynamicInvoke(source);
        }

        public static string PropertyName<T, P>(this T source, Expression<Func<T, P>> expression)
            where T : class
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            return expression.PropertyName();
        }

        public static string PropertyDisplay<T, P>(this T source, Expression<Func<T, P>> expression)
            where T : class
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            return expression.PropertyDisplay();
        }

        public static string PropertyDescription<T, P>(this T source, Expression<Func<T, P>> expression)
            where T : class
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            return expression.PropertyDescription();
        }

        public static string PropertyTrail<T, P>(this T source, Expression<Func<T, P>> expression)
            where T : class
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            return expression.PropertyTrail();
        }
    }
}
