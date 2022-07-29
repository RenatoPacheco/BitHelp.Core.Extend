using System.Linq;
using System.Reflection;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BitHelp.Core.Extend
{
    public static class PropertyInfoExtend
    {
        public static string PropertyDisplay(this PropertyInfo source)
        {
            DisplayAttribute display = (DisplayAttribute)source.GetCustomAttributes(typeof(DisplayAttribute), false)?.FirstOrDefault();
            string result = display?.Name ?? source.Name;

            return result;
        }

        public static string PropertyDescription(this PropertyInfo source)
        {
            DescriptionAttribute description = (DescriptionAttribute)source.GetCustomAttributes(typeof(DescriptionAttribute), false)?.FirstOrDefault();
            string result = description?.Description;

            return result;
        }
    }
}
