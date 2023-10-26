using System;
using System.Linq;
using System.Globalization;

namespace BitHelp.Core.Extend
{
    public static class StringExtend
    {
        public static bool DoesCultureExist(this string source)
        {
            return !string.IsNullOrEmpty(source) && CultureInfo.GetCultures(CultureTypes.AllCultures).Any(
                culture => string.Equals(culture.Name, source, StringComparison.CurrentCultureIgnoreCase));
        }

        public static bool NonCultureExist(this string source)
        {
            return string.IsNullOrEmpty(source) || !CultureInfo.GetCultures(CultureTypes.AllCultures).Any(
                culture => string.Equals(culture.Name, source, StringComparison.CurrentCultureIgnoreCase));
        }
    }
}
