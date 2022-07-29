using Xunit;
using System;
using System.Linq.Expressions;

namespace BitHelp.Core.Extend.Test.ExpressionExtendTest
{
    public class PropertyTrailTest
    {
        private static string PropertyTrail<T>(Expression<Func<T, object>> expression)
        {
#pragma warning disable CS0618 // Type or member is obsolete
            return expression.PropertyTrail();
#pragma warning restore CS0618 // Type or member is obsolete
        }

        [Fact]
        public void Check_property_trail()
        {
            SingleValues single = new SingleValues();
            ArrayValues array = new ArrayValues();

            Assert.Equal(nameof(single.Char), PropertyTrail<SingleValues>(x => x.Char));
            Assert.Equal(nameof(single.String), PropertyTrail<SingleValues>(x => x.String));
            Assert.Equal(nameof(single.Int), PropertyTrail<SingleValues>(x => x.Int));
            Assert.Equal(nameof(single.IntNull), PropertyTrail<SingleValues>(x => x.IntNull));
            Assert.Equal(nameof(single.Long), PropertyTrail<SingleValues>(x => x.Long));
            Assert.Equal(nameof(single.LongNull), PropertyTrail<SingleValues>(x => x.LongNull));
            Assert.Equal(nameof(single.Decimal), PropertyTrail<SingleValues>(x => x.Decimal));
            Assert.Equal(nameof(single.DecimalNull), PropertyTrail<SingleValues>(x => x.DecimalNull));
            Assert.Equal(nameof(single.Uint), PropertyTrail<SingleValues>(x => x.Uint));
            Assert.Equal(nameof(single.UintNull), PropertyTrail<SingleValues>(x => x.UintNull));
            Assert.Equal(nameof(single.DateTime), PropertyTrail<SingleValues>(x => x.DateTime));
            Assert.Equal(nameof(single.DateTimeNull), PropertyTrail<SingleValues>(x => x.DateTimeNull));
            Assert.Equal(nameof(single.Guid), PropertyTrail<SingleValues>(x => x.Guid));
            Assert.Equal(nameof(single.GuidNull), PropertyTrail<SingleValues>(x => x.GuidNull));
            Assert.Equal(nameof(single.Bool), PropertyTrail<SingleValues>(x => x.Bool));
            Assert.Equal(nameof(single.BoolNull), PropertyTrail<SingleValues>(x => x.BoolNull));

            Assert.Equal(nameof(array.Char), PropertyTrail<ArrayValues>(x => x.Char));
            Assert.Equal(nameof(array.String), PropertyTrail<ArrayValues>(x => x.String));
            Assert.Equal(nameof(array.Int), PropertyTrail<ArrayValues>(x => x.Int));
            Assert.Equal(nameof(array.Long), PropertyTrail<ArrayValues>(x => x.Long));
            Assert.Equal(nameof(array.Decimal), PropertyTrail<ArrayValues>(x => x.Decimal));
            Assert.Equal(nameof(array.Uint), PropertyTrail<ArrayValues>(x => x.Uint));
            Assert.Equal(nameof(array.DateTime), PropertyTrail<ArrayValues>(x => x.DateTime));
            Assert.Equal(nameof(array.Guid), PropertyTrail<ArrayValues>(x => x.Guid));
            Assert.Equal(nameof(array.Bool), PropertyTrail<ArrayValues>(x => x.Bool));
        }

        [Fact]
        public void Check_property_trail_in_subclass()
        {
            Assert.Equal("SingleValues.Char", PropertyTrail<AllValues>(x => x.SingleValues.Char));
            Assert.Equal("SingleValues.String", PropertyTrail<AllValues>(x => x.SingleValues.String));
            Assert.Equal("SingleValues.Int", PropertyTrail<AllValues>(x => x.SingleValues.Int));
            Assert.Equal("SingleValues.IntNull", PropertyTrail<AllValues>(x => x.SingleValues.IntNull));
            Assert.Equal("SingleValues.Long", PropertyTrail<AllValues>(x => x.SingleValues.Long));
            Assert.Equal("SingleValues.LongNull", PropertyTrail<AllValues>(x => x.SingleValues.LongNull));
            Assert.Equal("SingleValues.Decimal", PropertyTrail<AllValues>(x => x.SingleValues.Decimal));
            Assert.Equal("SingleValues.DecimalNull", PropertyTrail<AllValues>(x => x.SingleValues.DecimalNull));
            Assert.Equal("SingleValues.Uint", PropertyTrail<AllValues>(x => x.SingleValues.Uint));
            Assert.Equal("SingleValues.UintNull", PropertyTrail<AllValues>(x => x.SingleValues.UintNull));
            Assert.Equal("SingleValues.DateTime", PropertyTrail<AllValues>(x => x.SingleValues.DateTime));
            Assert.Equal("SingleValues.DateTimeNull", PropertyTrail<AllValues>(x => x.SingleValues.DateTimeNull));
            Assert.Equal("SingleValues.Guid", PropertyTrail<AllValues>(x => x.SingleValues.Guid));
            Assert.Equal("SingleValues.GuidNull", PropertyTrail<AllValues>(x => x.SingleValues.GuidNull));
            Assert.Equal("SingleValues.Bool", PropertyTrail<AllValues>(x => x.SingleValues.Bool));
            Assert.Equal("SingleValues.BoolNull", PropertyTrail<AllValues>(x => x.SingleValues.BoolNull));

            Assert.Equal("ArrayValues.Char", PropertyTrail<AllValues>(x => x.ArrayValues.Char));
            Assert.Equal("ArrayValues.String", PropertyTrail<AllValues>(x => x.ArrayValues.String));
            Assert.Equal("ArrayValues.Int", PropertyTrail<AllValues>(x => x.ArrayValues.Int));
            Assert.Equal("ArrayValues.Long", PropertyTrail<AllValues>(x => x.ArrayValues.Long));
            Assert.Equal("ArrayValues.Decimal", PropertyTrail<AllValues>(x => x.ArrayValues.Decimal));
            Assert.Equal("ArrayValues.Uint", PropertyTrail<AllValues>(x => x.ArrayValues.Uint));
            Assert.Equal("ArrayValues.DateTime", PropertyTrail<AllValues>(x => x.ArrayValues.DateTime));
            Assert.Equal("ArrayValues.Guid", PropertyTrail<AllValues>(x => x.ArrayValues.Guid));
            Assert.Equal("ArrayValues.Bool", PropertyTrail<AllValues>(x => x.ArrayValues.Bool));
        }
    }
}
