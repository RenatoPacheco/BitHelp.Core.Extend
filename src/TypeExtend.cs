using System;
using System.Collections;

namespace BitHelp.Core.Extend
{
    public static class TypeExtend
    {
        public static bool IsList(this Type value)
        {
            return value != typeof(string)
                && (typeof(IEnumerable).IsAssignableFrom(value)
                || typeof(IList).IsAssignableFrom(value));
        }
    }
}
