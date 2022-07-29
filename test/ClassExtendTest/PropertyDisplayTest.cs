using Xunit;

namespace BitHelp.Core.Extend.Test.ClassExtendTest
{
    public class PropertyDisplayTest
    {
        [Fact]
        public void Check_property_disply()
        {
            SingleValues single = new();
            ArrayValues array = new();

            Assert.Equal(nameof(single.Char), single.PropertyDisplay(x => x.Char));
            Assert.Equal(nameof(single.String), single.PropertyDisplay(x => x.String));
            Assert.Equal(nameof(single.Int), single.PropertyDisplay(x => x.Int));
            Assert.Equal("Int null", single.PropertyDisplay(x => x.IntNull));
            Assert.Equal(nameof(single.Long), single.PropertyDisplay(x => x.Long));
            Assert.Equal("Long null", single.PropertyDisplay(x => x.LongNull));
            Assert.Equal(nameof(single.Decimal), single.PropertyDisplay(x => x.Decimal));
            Assert.Equal("Decimal null", single.PropertyDisplay(x => x.DecimalNull));
            Assert.Equal(nameof(single.Uint), single.PropertyDisplay(x => x.Uint));
            Assert.Equal("Uint null", single.PropertyDisplay(x => x.UintNull));
            Assert.Equal("Date time", single.PropertyDisplay(x => x.DateTime));
            Assert.Equal("Date time null", single.PropertyDisplay(x => x.DateTimeNull));
            Assert.Equal(nameof(single.Guid), single.PropertyDisplay(x => x.Guid));
            Assert.Equal("Guid null", single.PropertyDisplay(x => x.GuidNull));
            Assert.Equal(nameof(single.Bool), single.PropertyDisplay(x => x.Bool));
            Assert.Equal("Bool null", single.PropertyDisplay(x => x.BoolNull));

            Assert.Equal("Array char", array.PropertyDisplay(x => x.Char));
            Assert.Equal("Array string", array.PropertyDisplay(x => x.String));
            Assert.Equal("Array int", array.PropertyDisplay(x => x.Int));
            Assert.Equal("Array long", array.PropertyDisplay(x => x.Long));
            Assert.Equal("Array decimal", array.PropertyDisplay(x => x.Decimal));
            Assert.Equal("Array uint", array.PropertyDisplay(x => x.Uint));
            Assert.Equal("Array date time", array.PropertyDisplay(x => x.DateTime));
            Assert.Equal("Array guid", array.PropertyDisplay(x => x.Guid));
            Assert.Equal("Array bool", array.PropertyDisplay(x => x.Bool));
        }

        [Fact]
        public void Check_property_display_in_subclass()
        {
            AllValues all = new();

            Assert.Equal("String", all.PropertyDisplay(x => x.SingleValues.String));
            Assert.Equal("Int null", all.PropertyDisplay(x => x.SingleValues.IntNull));
            Assert.Equal("Array string", all.PropertyDisplay(x => x.ArrayValues.String));
        }
    }
}
