using Xunit;

namespace BitHelp.Core.Extend.Test.ClassExtendTest
{
    public class PropertyPathTest
    {
        [Fact]
        public void Check_property_trail()
        {
            SingleValues single = new SingleValues();
            ArrayValues array = new ArrayValues();

            Assert.Equal(nameof(single.Char), single.PropertyPath(x => x.Char));
            Assert.Equal(nameof(single.String), single.PropertyPath(x => x.String));
            Assert.Equal(nameof(single.Int), single.PropertyPath(x => x.Int));
            Assert.Equal(nameof(single.IntNull), single.PropertyPath(x => x.IntNull));
            Assert.Equal(nameof(single.Long), single.PropertyPath(x => x.Long));
            Assert.Equal(nameof(single.LongNull), single.PropertyPath(x => x.LongNull));
            Assert.Equal(nameof(single.Decimal), single.PropertyPath(x => x.Decimal));
            Assert.Equal(nameof(single.DecimalNull), single.PropertyPath(x => x.DecimalNull));
            Assert.Equal(nameof(single.Uint), single.PropertyPath(x => x.Uint));
            Assert.Equal(nameof(single.UintNull), single.PropertyPath(x => x.UintNull));
            Assert.Equal(nameof(single.DateTime), single.PropertyPath(x => x.DateTime));
            Assert.Equal(nameof(single.DateTimeNull), single.PropertyPath(x => x.DateTimeNull));
            Assert.Equal(nameof(single.Guid), single.PropertyPath(x => x.Guid));
            Assert.Equal(nameof(single.GuidNull), single.PropertyPath(x => x.GuidNull));
            Assert.Equal(nameof(single.Bool), single.PropertyPath(x => x.Bool));
            Assert.Equal(nameof(single.BoolNull), single.PropertyPath(x => x.BoolNull));

            Assert.Equal(nameof(array.Char), array.PropertyPath(x => x.Char));
            Assert.Equal(nameof(array.String), array.PropertyPath(x => x.String));
            Assert.Equal(nameof(array.Int), array.PropertyPath(x => x.Int));
            Assert.Equal(nameof(array.Long), array.PropertyPath(x => x.Long));
            Assert.Equal(nameof(array.Decimal), array.PropertyPath(x => x.Decimal));
            Assert.Equal(nameof(array.Uint), array.PropertyPath(x => x.Uint));
            Assert.Equal(nameof(array.DateTime), array.PropertyPath(x => x.DateTime));
            Assert.Equal(nameof(array.Guid), array.PropertyPath(x => x.Guid));
            Assert.Equal(nameof(array.Bool), array.PropertyPath(x => x.Bool));
        }

        [Fact]
        public void Check_property_trail_in_subclass()
        {
            AllValues all = new AllValues();

            Assert.Equal("SingleValues.Char", all.PropertyPath(x => x.SingleValues.Char));
            Assert.Equal("SingleValues.String", all.PropertyPath(x => x.SingleValues.String));
            Assert.Equal("SingleValues.Int", all.PropertyPath(x => x.SingleValues.Int));
            Assert.Equal("SingleValues.IntNull", all.PropertyPath(x => x.SingleValues.IntNull));
            Assert.Equal("SingleValues.Long", all.PropertyPath(x => x.SingleValues.Long));
            Assert.Equal("SingleValues.LongNull", all.PropertyPath(x => x.SingleValues.LongNull));
            Assert.Equal("SingleValues.Decimal", all.PropertyPath(x => x.SingleValues.Decimal));
            Assert.Equal("SingleValues.DecimalNull", all.PropertyPath(x => x.SingleValues.DecimalNull));
            Assert.Equal("SingleValues.Uint", all.PropertyPath(x => x.SingleValues.Uint));
            Assert.Equal("SingleValues.UintNull", all.PropertyPath(x => x.SingleValues.UintNull));
            Assert.Equal("SingleValues.DateTime", all.PropertyPath(x => x.SingleValues.DateTime));
            Assert.Equal("SingleValues.DateTimeNull", all.PropertyPath(x => x.SingleValues.DateTimeNull));
            Assert.Equal("SingleValues.Guid", all.PropertyPath(x => x.SingleValues.Guid));
            Assert.Equal("SingleValues.GuidNull", all.PropertyPath(x => x.SingleValues.GuidNull));
            Assert.Equal("SingleValues.Bool", all.PropertyPath(x => x.SingleValues.Bool));
            Assert.Equal("SingleValues.BoolNull", all.PropertyPath(x => x.SingleValues.BoolNull));

            Assert.Equal("ArrayValues.Char", all.PropertyPath(x => x.ArrayValues.Char));
            Assert.Equal("ArrayValues.String", all.PropertyPath(x => x.ArrayValues.String));
            Assert.Equal("ArrayValues.Int", all.PropertyPath(x => x.ArrayValues.Int));
            Assert.Equal("ArrayValues.Long", all.PropertyPath(x => x.ArrayValues.Long));
            Assert.Equal("ArrayValues.Decimal", all.PropertyPath(x => x.ArrayValues.Decimal));
            Assert.Equal("ArrayValues.Uint", all.PropertyPath(x => x.ArrayValues.Uint));
            Assert.Equal("ArrayValues.DateTime", all.PropertyPath(x => x.ArrayValues.DateTime));
            Assert.Equal("ArrayValues.Guid", all.PropertyPath(x => x.ArrayValues.Guid));
            Assert.Equal("ArrayValues.Bool", all.PropertyPath(x => x.ArrayValues.Bool));
        }
    }
}
