using Xunit;

namespace BitHelp.Core.Extend.Test.ClassExtendTest
{
    public class PropertyDescriptionTest
    {
        [Fact]
        public void Check_property_disply()
        {
            SingleValues single = new();
            ArrayValues array = new();

            Assert.Equal("Char description", single.PropertyDescription(x => x.Char));
            Assert.Equal("String description", single.PropertyDescription(x => x.String));
            Assert.Equal("Int description", single.PropertyDescription(x => x.Int));
            Assert.Null(single.PropertyDescription(x => x.IntNull));
            Assert.Equal("Long description", single.PropertyDescription(x => x.Long));
            Assert.Null(single.PropertyDescription(x => x.LongNull));
            Assert.Equal("Decimal description", single.PropertyDescription(x => x.Decimal));
            Assert.Null(single.PropertyDescription(x => x.DecimalNull));
            Assert.Equal("Uint description", single.PropertyDescription(x => x.Uint));
            Assert.Null(single.PropertyDescription(x => x.UintNull));
            Assert.Null(single.PropertyDescription(x => x.DateTime));
            Assert.Null(single.PropertyDescription(x => x.DateTimeNull));
            Assert.Equal("Guid description", single.PropertyDescription(x => x.Guid));
            Assert.Null(single.PropertyDescription(x => x.GuidNull));
            Assert.Equal("Bool description", single.PropertyDescription(x => x.Bool));
            Assert.Null(single.PropertyDescription(x => x.BoolNull));

            Assert.Null(array.PropertyDescription(x => x.Char));
            Assert.Null(array.PropertyDescription(x => x.String));
            Assert.Null(array.PropertyDescription(x => x.Int));
            Assert.Null(array.PropertyDescription(x => x.Long));
            Assert.Null(array.PropertyDescription(x => x.Decimal));
            Assert.Null(array.PropertyDescription(x => x.Uint));
            Assert.Null(array.PropertyDescription(x => x.DateTime));
            Assert.Null(array.PropertyDescription(x => x.Guid));
            Assert.Null(array.PropertyDescription(x => x.Bool));
        }

        [Fact]
        public void Check_property_display_in_subclass()
        {
            AllValues all = new();

            Assert.Equal("String description", all.PropertyDescription(x => x.SingleValues.String));
            Assert.Null(all.PropertyDescription(x => x.SingleValues.IntNull));
            Assert.Null(all.PropertyDescription(x => x.ArrayValues.String));
        }
    }
}
