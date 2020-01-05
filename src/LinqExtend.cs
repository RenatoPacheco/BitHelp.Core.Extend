using System;
using System.Collections.Generic;

namespace BitHelp.Core.Extend
{
    public static class LinqExtend
    {
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (var item in source)
                action(item);
        }

        public static IEnumerable<T> DistinctBy<T, K>
            (this IEnumerable<T> source, Func<T, K> keySelector)
        {
            HashSet<K> knownKeys = new HashSet<K>();
            foreach (T element in source)
            {
                if (knownKeys.Add(keySelector(element)))
                {
                    yield return element;
                }
            }
        }
    }
}
