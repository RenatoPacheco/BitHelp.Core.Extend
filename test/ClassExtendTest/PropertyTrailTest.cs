using Xunit;

#pragma warning disable CS0618 // Type or member is obsolete
namespace BitHelp.Core.Extend.Test.ClassExtendTest
{
    public class PropertyTrailTest
    {
        [Fact]
        public void Check_property_trail()
        {
            SingleValues single = new();
            ArrayValues array = new();

            Assert.Equal(nameof(single.Char), single.PropertyTrail(x => x.Char));
            Assert.Equal(nameof(single.String), single.PropertyTrail(x => x.String));
            Assert.Equal(nameof(single.Int), single.PropertyTrail(x => x.Int));
            Assert.Equal(nameof(single.IntNull), single.PropertyTrail(x => x.IntNull));
            Assert.Equal(nameof(single.Long), single.PropertyTrail(x => x.Long));
            Assert.Equal(nameof(single.LongNull), single.PropertyTrail(x => x.LongNull));
            Assert.Equal(nameof(single.Decimal), single.PropertyTrail(x => x.Decimal));
            Assert.Equal(nameof(single.DecimalNull), single.PropertyTrail(x => x.DecimalNull));
            Assert.Equal(nameof(single.Uint), single.PropertyTrail(x => x.Uint));
            Assert.Equal(nameof(single.UintNull), single.PropertyTrail(x => x.UintNull));
            Assert.Equal(nameof(single.DateTime), single.PropertyTrail(x => x.DateTime));
            Assert.Equal(nameof(single.DateTimeNull), single.PropertyTrail(x => x.DateTimeNull));
            Assert.Equal(nameof(single.Guid), single.PropertyTrail(x => x.Guid));
            Assert.Equal(nameof(single.GuidNull), single.PropertyTrail(x => x.GuidNull));
            Assert.Equal(nameof(single.Bool), single.PropertyTrail(x => x.Bool));
            Assert.Equal(nameof(single.BoolNull), single.PropertyTrail(x => x.BoolNull));

            Assert.Equal(nameof(array.Char), array.PropertyTrail(x => x.Char));
            Assert.Equal(nameof(array.String), array.PropertyTrail(x => x.String));
            Assert.Equal(nameof(array.Int), array.PropertyTrail(x => x.Int));
            Assert.Equal(nameof(array.Long), array.PropertyTrail(x => x.Long));
            Assert.Equal(nameof(array.Decimal), array.PropertyTrail(x => x.Decimal));
            Assert.Equal(nameof(array.Uint), array.PropertyTrail(x => x.Uint));
            Assert.Equal(nameof(array.DateTime), array.PropertyTrail(x => x.DateTime));
            Assert.Equal(nameof(array.Guid), array.PropertyTrail(x => x.Guid));
            Assert.Equal(nameof(array.Bool), array.PropertyTrail(x => x.Bool));
        }

        [Fact]
        public void Check_property_trail_in_subclass()
        {
            AllValues all = new();

            Assert.Equal("SingleValues.Char", all.PropertyTrail(x => x.SingleValues.Char));
            Assert.Equal("SingleValues.String", all.PropertyTrail(x => x.SingleValues.String));
            Assert.Equal("SingleValues.Int", all.PropertyTrail(x => x.SingleValues.Int));
            Assert.Equal("SingleValues.IntNull", all.PropertyTrail(x => x.SingleValues.IntNull));
            Assert.Equal("SingleValues.Long", all.PropertyTrail(x => x.SingleValues.Long));
            Assert.Equal("SingleValues.LongNull", all.PropertyTrail(x => x.SingleValues.LongNull));
            Assert.Equal("SingleValues.Decimal", all.PropertyTrail(x => x.SingleValues.Decimal));
            Assert.Equal("SingleValues.DecimalNull", all.PropertyTrail(x => x.SingleValues.DecimalNull));
            Assert.Equal("SingleValues.Uint", all.PropertyTrail(x => x.SingleValues.Uint));
            Assert.Equal("SingleValues.UintNull", all.PropertyTrail(x => x.SingleValues.UintNull));
            Assert.Equal("SingleValues.DateTime", all.PropertyTrail(x => x.SingleValues.DateTime));
            Assert.Equal("SingleValues.DateTimeNull", all.PropertyTrail(x => x.SingleValues.DateTimeNull));
            Assert.Equal("SingleValues.Guid", all.PropertyTrail(x => x.SingleValues.Guid));
            Assert.Equal("SingleValues.GuidNull", all.PropertyTrail(x => x.SingleValues.GuidNull));
            Assert.Equal("SingleValues.Bool", all.PropertyTrail(x => x.SingleValues.Bool));
            Assert.Equal("SingleValues.BoolNull", all.PropertyTrail(x => x.SingleValues.BoolNull));

            Assert.Equal("ArrayValues.Char", all.PropertyTrail(x => x.ArrayValues.Char));
            Assert.Equal("ArrayValues.String", all.PropertyTrail(x => x.ArrayValues.String));
            Assert.Equal("ArrayValues.Int", all.PropertyTrail(x => x.ArrayValues.Int));
            Assert.Equal("ArrayValues.Long", all.PropertyTrail(x => x.ArrayValues.Long));
            Assert.Equal("ArrayValues.Decimal", all.PropertyTrail(x => x.ArrayValues.Decimal));
            Assert.Equal("ArrayValues.Uint", all.PropertyTrail(x => x.ArrayValues.Uint));
            Assert.Equal("ArrayValues.DateTime", all.PropertyTrail(x => x.ArrayValues.DateTime));
            Assert.Equal("ArrayValues.Guid", all.PropertyTrail(x => x.ArrayValues.Guid));
            Assert.Equal("ArrayValues.Bool", all.PropertyTrail(x => x.ArrayValues.Bool));
        }
    }
}
#pragma warning restore CS0618 // Type or member is obsolete
