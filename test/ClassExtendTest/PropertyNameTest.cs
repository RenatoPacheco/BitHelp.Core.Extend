using Xunit;

namespace BitHelp.Core.Extend.Test.ClassExtendTest
{
    public class PropertyNameTest
    {
        [Fact]
        public void Check_property_name()
        {
            SingleValues single = new SingleValues();
            ArrayValues array = new ArrayValues();

            Assert.Equal(nameof(single.Char), single.PropertyName(x => x.Char));
            Assert.Equal(nameof(single.String), single.PropertyName(x => x.String));
            Assert.Equal(nameof(single.Int), single.PropertyName(x => x.Int));
            Assert.Equal(nameof(single.IntNull), single.PropertyName(x => x.IntNull));
            Assert.Equal(nameof(single.Long), single.PropertyName(x => x.Long));
            Assert.Equal(nameof(single.LongNull), single.PropertyName(x => x.LongNull));
            Assert.Equal(nameof(single.Decimal), single.PropertyName(x => x.Decimal));
            Assert.Equal(nameof(single.DecimalNull), single.PropertyName(x => x.DecimalNull));
            Assert.Equal(nameof(single.Uint), single.PropertyName(x => x.Uint));
            Assert.Equal(nameof(single.UintNull), single.PropertyName(x => x.UintNull));
            Assert.Equal(nameof(single.DateTime), single.PropertyName(x => x.DateTime));
            Assert.Equal(nameof(single.DateTimeNull), single.PropertyName(x => x.DateTimeNull));
            Assert.Equal(nameof(single.Guid), single.PropertyName(x => x.Guid));
            Assert.Equal(nameof(single.GuidNull), single.PropertyName(x => x.GuidNull));
            Assert.Equal(nameof(single.Bool), single.PropertyName(x => x.Bool));
            Assert.Equal(nameof(single.BoolNull), single.PropertyName(x => x.BoolNull));

            Assert.Equal(nameof(array.Char), array.PropertyName(x => x.Char));
            Assert.Equal(nameof(array.String), array.PropertyName(x => x.String));
            Assert.Equal(nameof(array.Int), array.PropertyName(x => x.Int));
            Assert.Equal(nameof(array.Long), array.PropertyName(x => x.Long));
            Assert.Equal(nameof(array.Decimal), array.PropertyName(x => x.Decimal));
            Assert.Equal(nameof(array.Uint), array.PropertyName(x => x.Uint));
            Assert.Equal(nameof(array.DateTime), array.PropertyName(x => x.DateTime));
            Assert.Equal(nameof(array.Guid), array.PropertyName(x => x.Guid));
            Assert.Equal(nameof(array.Bool), array.PropertyName(x => x.Bool));
        }

        [Fact]
        public void Check_property_name_in_subclass()
        {
            SingleValues single = new SingleValues();
            ArrayValues array = new ArrayValues();
            AllValues all = new AllValues();

            Assert.Equal(nameof(single.String), all.PropertyName(x => x.SingleValues.String));
            Assert.Equal(nameof(array.String), all.PropertyName(x => x.ArrayValues.String));
        }
    }
}
