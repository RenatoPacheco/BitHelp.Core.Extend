using System.Linq;
using System.Reflection;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BitHelp.Core.Extend
{
    public static class StructExtend
    {
        public static string Display<T>(this T source)
            where T : struct
        {
            string output = source.ToString();
            MemberInfo member = source.GetType().GetMember(output).First();
            DisplayAttribute attribute = (DisplayAttribute)member.GetCustomAttributes(typeof(DisplayAttribute), false).FirstOrDefault();

            return attribute?.Name ?? output;
        }

        public static string Description<T>(this T source)
            where T : struct
        {
            string output = source.ToString();
            MemberInfo member = source.GetType().GetMember(output).First();
            DescriptionAttribute attribute = (DescriptionAttribute)member.GetCustomAttributes(typeof(DescriptionAttribute), false).FirstOrDefault();

            return attribute?.Description;
        }
    }
}
