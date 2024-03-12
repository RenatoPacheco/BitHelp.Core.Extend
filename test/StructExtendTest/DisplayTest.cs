using Xunit;

namespace BitHelp.Core.Extend.Test.StructExtendTest
{
    public class DisplayTest
    {
        [Fact]
        public void Check_contain_display()
        {
            var item = new StructValue<EnumValue>(EnumValue.One);

            Assert.Equal("One name", item.GetDisplay());
        }

        [Fact]
        public void Check_not_contain_display()
        {
            var item = new StructValue<EnumValue>(EnumValue.Three);

            Assert.Equal("Three", item.GetDisplay());
        }
    }
}
