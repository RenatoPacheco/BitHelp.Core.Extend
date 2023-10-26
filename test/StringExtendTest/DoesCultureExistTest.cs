using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BitHelp.Core.Extend.Test.StringExtendTest
{
    public class DoesCultureExistTest
    {
        [Theory]
        [InlineData("pt-BR")]
        [InlineData("en-US")]
        [InlineData("PT-BR")]
        public void Check_value_is_culture_valid(string input)
        {
            Assert.True(input.DoesCultureExist(), $"Expected: True \nActual: False \nValue: {input}");
            Assert.Equal(input.ToLower(), (new CultureInfo(input)).ToString().ToLower());
        }

        [Theory]
        [InlineData("PT-US")]
        [InlineData("pt-US")]
        [InlineData("  pt-BR  ")]
        [InlineData("     ")]
        [InlineData("")]
        [InlineData(null)]
        public void Check_value_is_culture_invalid(string input)
        {
            Assert.False(input.DoesCultureExist(), $"Expected: False \nActual: True \nValue: {input}");
        }
    }
}
