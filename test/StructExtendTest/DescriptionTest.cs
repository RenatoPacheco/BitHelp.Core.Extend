using System;
using Xunit;

namespace BitHelp.Core.Extend.Test.StructExtendTest
{
    public class DescriptionTest
     {
        [Fact]
        public void Check_contain_description()
        {
            var item = new StructValue<EnumValue>(EnumValue.Two);

            Assert.Equal("Two description", item.GetDescription());
        }

        [Fact]
        public void Check_not_contain_description()
        {
            var item = new StructValue<EnumValue>(EnumValue.Three);

            Assert.Null(item.GetDescription());
        }
    }
}
