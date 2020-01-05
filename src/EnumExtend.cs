using System;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BitHelp.Core.Extend
{
    public static class EnumExtend
    {
        public static string Display(this Enum source)
        {
            var output = source.ToString();
            var member = source.GetType().GetMember(output).First();
            var attribute = (DisplayAttribute)member.GetCustomAttributes(typeof(DisplayAttribute), false).FirstOrDefault();

            return attribute?.Name ?? output;
        }

        public static string Description(this Enum source)
        {
            var output = source.ToString();
            var member = source.GetType().GetMember(output).First();
            var attribute = (DescriptionAttribute)member.GetCustomAttributes(typeof(DescriptionAttribute), false).FirstOrDefault();

            return attribute?.Description;
        }
    }
}
