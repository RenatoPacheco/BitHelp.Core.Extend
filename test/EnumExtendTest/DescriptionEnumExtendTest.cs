using System;
using Xunit;

namespace BitHelp.Core.Extend.Test.EnumExtendTest
{
    public class DescriptionEnumExtendTest
    {
        [Fact]
        public void Check_contain_description()
        {
            Enum value = EnumValue.Two;

            Assert.Equal("Two description", value.Description());
        }

        [Fact]
        public void Check_not_contain_description()
        {
            Enum value = EnumValue.Three;

            Assert.Null(value.Description());
        }
    }
}
