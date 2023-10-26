using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BitHelp.Core.Extend.Test.StringExtendTest
{
    public class NonCultureExistTest
    {
        [Theory]
        [InlineData("pt-BR")]
        [InlineData("en-US")]
        [InlineData("PT-BR")]
        public void Check_value_not_is_culture_invalid(string input)
        {
            Assert.False(input.NonCultureExist(), $"Expected: True \nActual: False \nValue: {input}");
            Assert.Equal(input.ToLower(), (new CultureInfo(input)).ToString().ToLower());
        }

        [Theory]
        [InlineData("PT-US")]
        [InlineData("pt-US")]
        [InlineData("  pt-BR  ")]
        [InlineData("     ")]
        [InlineData("")]
        [InlineData(null)]
        public void Check_value__not_is_culture_valid(string input)
        {
            Assert.True(input.NonCultureExist(), $"Expected: False \nActual: True \nValue: {input}");
        }
    }
}
