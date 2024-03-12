using System;
using Xunit;

namespace BitHelp.Core.Extend.Test.EnumExtendTest
{
    public class DisplayTest
    {
        [Fact]
        public void Check_contain_display()
        {
            Enum value = EnumValue.One;

            Assert.Equal("One name", value.Display());
        }

        [Fact]
        public void Check_not_contain_display()
        {
            Enum value = EnumValue.Three;

            Assert.Equal("Three", value.Display());
        }
    }
}
