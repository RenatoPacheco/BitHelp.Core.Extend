using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BitHelp.Core.Extend.Test
{
    internal enum EnumValue
    {
        [Display(Name = "One name")]
        One,
        [Description("Two description")]
        Two,
        Three
    }
}