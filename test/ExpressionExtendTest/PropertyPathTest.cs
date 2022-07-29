using Xunit;
using System;
using System.Linq.Expressions;

namespace BitHelp.Core.Extend.Test.ExpressionExtendTest
{
    public class PropertyPathTest
    {
        private static string PropertyPath<T>(Expression<Func<T, object>> expression)
        {
            return expression.PropertyPath();
        }

        [Fact]
        public void Check_property_trail()
        {
            SingleValues single = new();
            ArrayValues array = new();

            Assert.Equal(nameof(single.Char), PropertyPath<SingleValues>(x => x.Char));
            Assert.Equal(nameof(single.String), PropertyPath<SingleValues>(x => x.String));
            Assert.Equal(nameof(single.Int), PropertyPath<SingleValues>(x => x.Int));
            Assert.Equal(nameof(single.IntNull), PropertyPath<SingleValues>(x => x.IntNull));
            Assert.Equal(nameof(single.Long), PropertyPath<SingleValues>(x => x.Long));
            Assert.Equal(nameof(single.LongNull), PropertyPath<SingleValues>(x => x.LongNull));
            Assert.Equal(nameof(single.Decimal), PropertyPath<SingleValues>(x => x.Decimal));
            Assert.Equal(nameof(single.DecimalNull), PropertyPath<SingleValues>(x => x.DecimalNull));
            Assert.Equal(nameof(single.Uint), PropertyPath<SingleValues>(x => x.Uint));
            Assert.Equal(nameof(single.UintNull), PropertyPath<SingleValues>(x => x.UintNull));
            Assert.Equal(nameof(single.DateTime), PropertyPath<SingleValues>(x => x.DateTime));
            Assert.Equal(nameof(single.DateTimeNull), PropertyPath<SingleValues>(x => x.DateTimeNull));
            Assert.Equal(nameof(single.Guid), PropertyPath<SingleValues>(x => x.Guid));
            Assert.Equal(nameof(single.GuidNull), PropertyPath<SingleValues>(x => x.GuidNull));
            Assert.Equal(nameof(single.Bool), PropertyPath<SingleValues>(x => x.Bool));
            Assert.Equal(nameof(single.BoolNull), PropertyPath<SingleValues>(x => x.BoolNull));

            Assert.Equal(nameof(array.Char), PropertyPath<ArrayValues>(x => x.Char));
            Assert.Equal(nameof(array.String), PropertyPath<ArrayValues>(x => x.String));
            Assert.Equal(nameof(array.Int), PropertyPath<ArrayValues>(x => x.Int));
            Assert.Equal(nameof(array.Long), PropertyPath<ArrayValues>(x => x.Long));
            Assert.Equal(nameof(array.Decimal), PropertyPath<ArrayValues>(x => x.Decimal));
            Assert.Equal(nameof(array.Uint), PropertyPath<ArrayValues>(x => x.Uint));
            Assert.Equal(nameof(array.DateTime), PropertyPath<ArrayValues>(x => x.DateTime));
            Assert.Equal(nameof(array.Guid), PropertyPath<ArrayValues>(x => x.Guid));
            Assert.Equal(nameof(array.Bool), PropertyPath<ArrayValues>(x => x.Bool));
        }

        [Fact]
        public void Check_property_trail_in_subclass()
        {
            Assert.Equal("SingleValues.Char", PropertyPath<AllValues>(x => x.SingleValues.Char));
            Assert.Equal("SingleValues.String", PropertyPath<AllValues>(x => x.SingleValues.String));
            Assert.Equal("SingleValues.Int", PropertyPath<AllValues>(x => x.SingleValues.Int));
            Assert.Equal("SingleValues.IntNull", PropertyPath<AllValues>(x => x.SingleValues.IntNull));
            Assert.Equal("SingleValues.Long", PropertyPath<AllValues>(x => x.SingleValues.Long));
            Assert.Equal("SingleValues.LongNull", PropertyPath<AllValues>(x => x.SingleValues.LongNull));
            Assert.Equal("SingleValues.Decimal", PropertyPath<AllValues>(x => x.SingleValues.Decimal));
            Assert.Equal("SingleValues.DecimalNull", PropertyPath<AllValues>(x => x.SingleValues.DecimalNull));
            Assert.Equal("SingleValues.Uint", PropertyPath<AllValues>(x => x.SingleValues.Uint));
            Assert.Equal("SingleValues.UintNull", PropertyPath<AllValues>(x => x.SingleValues.UintNull));
            Assert.Equal("SingleValues.DateTime", PropertyPath<AllValues>(x => x.SingleValues.DateTime));
            Assert.Equal("SingleValues.DateTimeNull", PropertyPath<AllValues>(x => x.SingleValues.DateTimeNull));
            Assert.Equal("SingleValues.Guid", PropertyPath<AllValues>(x => x.SingleValues.Guid));
            Assert.Equal("SingleValues.GuidNull", PropertyPath<AllValues>(x => x.SingleValues.GuidNull));
            Assert.Equal("SingleValues.Bool", PropertyPath<AllValues>(x => x.SingleValues.Bool));
            Assert.Equal("SingleValues.BoolNull", PropertyPath<AllValues>(x => x.SingleValues.BoolNull));

            Assert.Equal("ArrayValues.Char", PropertyPath<AllValues>(x => x.ArrayValues.Char));
            Assert.Equal("ArrayValues.String", PropertyPath<AllValues>(x => x.ArrayValues.String));
            Assert.Equal("ArrayValues.Int", PropertyPath<AllValues>(x => x.ArrayValues.Int));
            Assert.Equal("ArrayValues.Long", PropertyPath<AllValues>(x => x.ArrayValues.Long));
            Assert.Equal("ArrayValues.Decimal", PropertyPath<AllValues>(x => x.ArrayValues.Decimal));
            Assert.Equal("ArrayValues.Uint", PropertyPath<AllValues>(x => x.ArrayValues.Uint));
            Assert.Equal("ArrayValues.DateTime", PropertyPath<AllValues>(x => x.ArrayValues.DateTime));
            Assert.Equal("ArrayValues.Guid", PropertyPath<AllValues>(x => x.ArrayValues.Guid));
            Assert.Equal("ArrayValues.Bool", PropertyPath<AllValues>(x => x.ArrayValues.Bool));
        }
    }
}
