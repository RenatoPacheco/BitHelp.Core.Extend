using System;
using System.Linq;
using System.Reflection;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BitHelp.Core.Extend
{
    public static class EnumExtend
    {
        public static string Display(this Enum source)
        {
            string output = source.ToString();
            MemberInfo member = source.GetType().GetMember(output).First();
            DisplayAttribute attribute = (DisplayAttribute)member.GetCustomAttributes(typeof(DisplayAttribute), false).FirstOrDefault();

            return attribute?.Name ?? output;
        }

        public static string Description(this Enum source)
        {
            string output = source.ToString();
            MemberInfo member = source.GetType().GetMember(output).First();
            DescriptionAttribute attribute = (DescriptionAttribute)member.GetCustomAttributes(typeof(DescriptionAttribute), false).FirstOrDefault();

            return attribute?.Description;
        }
    }
}
