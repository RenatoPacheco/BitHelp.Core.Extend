using Xunit;
using System;
using System.Linq.Expressions;

namespace BitHelp.Core.Extend.Test.ExpressionExtendTest
{
    public class PropertyPathTest
    {
        private string PropertyPath<T>(Expression<Func<T, object>> expression)
        {
            return expression.PropertyPath();
        }

        [Fact]
        public void Check_property_trail()
        {
            SingleValues single = new SingleValues();
            ArrayValues array = new ArrayValues();

            Assert.Equal(nameof(single.Char), this.PropertyPath<SingleValues>(x => x.Char));
            Assert.Equal(nameof(single.String), this.PropertyPath<SingleValues>(x => x.String));
            Assert.Equal(nameof(single.Int), this.PropertyPath<SingleValues>(x => x.Int));
            Assert.Equal(nameof(single.IntNull), this.PropertyPath<SingleValues>(x => x.IntNull));
            Assert.Equal(nameof(single.Long), this.PropertyPath<SingleValues>(x => x.Long));
            Assert.Equal(nameof(single.LongNull), this.PropertyPath<SingleValues>(x => x.LongNull));
            Assert.Equal(nameof(single.Decimal), this.PropertyPath<SingleValues>(x => x.Decimal));
            Assert.Equal(nameof(single.DecimalNull), this.PropertyPath<SingleValues>(x => x.DecimalNull));
            Assert.Equal(nameof(single.Uint), this.PropertyPath<SingleValues>(x => x.Uint));
            Assert.Equal(nameof(single.UintNull), this.PropertyPath<SingleValues>(x => x.UintNull));
            Assert.Equal(nameof(single.DateTime), this.PropertyPath<SingleValues>(x => x.DateTime));
            Assert.Equal(nameof(single.DateTimeNull), this.PropertyPath<SingleValues>(x => x.DateTimeNull));
            Assert.Equal(nameof(single.Guid), this.PropertyPath<SingleValues>(x => x.Guid));
            Assert.Equal(nameof(single.GuidNull), this.PropertyPath<SingleValues>(x => x.GuidNull));
            Assert.Equal(nameof(single.Bool), this.PropertyPath<SingleValues>(x => x.Bool));
            Assert.Equal(nameof(single.BoolNull), this.PropertyPath<SingleValues>(x => x.BoolNull));

            Assert.Equal(nameof(array.Char), this.PropertyPath<ArrayValues>(x => x.Char));
            Assert.Equal(nameof(array.String), this.PropertyPath<ArrayValues>(x => x.String));
            Assert.Equal(nameof(array.Int), this.PropertyPath<ArrayValues>(x => x.Int));
            Assert.Equal(nameof(array.Long), this.PropertyPath<ArrayValues>(x => x.Long));
            Assert.Equal(nameof(array.Decimal), this.PropertyPath<ArrayValues>(x => x.Decimal));
            Assert.Equal(nameof(array.Uint), this.PropertyPath<ArrayValues>(x => x.Uint));
            Assert.Equal(nameof(array.DateTime), this.PropertyPath<ArrayValues>(x => x.DateTime));
            Assert.Equal(nameof(array.Guid), this.PropertyPath<ArrayValues>(x => x.Guid));
            Assert.Equal(nameof(array.Bool), this.PropertyPath<ArrayValues>(x => x.Bool));
        }

        [Fact]
        public void Check_property_trail_in_subclass()
        {
            Assert.Equal("SingleValues.Char", this.PropertyPath<AllValues>(x => x.SingleValues.Char));
            Assert.Equal("SingleValues.String", this.PropertyPath<AllValues>(x => x.SingleValues.String));
            Assert.Equal("SingleValues.Int", this.PropertyPath<AllValues>(x => x.SingleValues.Int));
            Assert.Equal("SingleValues.IntNull", this.PropertyPath<AllValues>(x => x.SingleValues.IntNull));
            Assert.Equal("SingleValues.Long", this.PropertyPath<AllValues>(x => x.SingleValues.Long));
            Assert.Equal("SingleValues.LongNull", this.PropertyPath<AllValues>(x => x.SingleValues.LongNull));
            Assert.Equal("SingleValues.Decimal", this.PropertyPath<AllValues>(x => x.SingleValues.Decimal));
            Assert.Equal("SingleValues.DecimalNull", this.PropertyPath<AllValues>(x => x.SingleValues.DecimalNull));
            Assert.Equal("SingleValues.Uint", this.PropertyPath<AllValues>(x => x.SingleValues.Uint));
            Assert.Equal("SingleValues.UintNull", this.PropertyPath<AllValues>(x => x.SingleValues.UintNull));
            Assert.Equal("SingleValues.DateTime", this.PropertyPath<AllValues>(x => x.SingleValues.DateTime));
            Assert.Equal("SingleValues.DateTimeNull", this.PropertyPath<AllValues>(x => x.SingleValues.DateTimeNull));
            Assert.Equal("SingleValues.Guid", this.PropertyPath<AllValues>(x => x.SingleValues.Guid));
            Assert.Equal("SingleValues.GuidNull", this.PropertyPath<AllValues>(x => x.SingleValues.GuidNull));
            Assert.Equal("SingleValues.Bool", this.PropertyPath<AllValues>(x => x.SingleValues.Bool));
            Assert.Equal("SingleValues.BoolNull", this.PropertyPath<AllValues>(x => x.SingleValues.BoolNull));

            Assert.Equal("ArrayValues.Char", this.PropertyPath<AllValues>(x => x.ArrayValues.Char));
            Assert.Equal("ArrayValues.String", this.PropertyPath<AllValues>(x => x.ArrayValues.String));
            Assert.Equal("ArrayValues.Int", this.PropertyPath<AllValues>(x => x.ArrayValues.Int));
            Assert.Equal("ArrayValues.Long", this.PropertyPath<AllValues>(x => x.ArrayValues.Long));
            Assert.Equal("ArrayValues.Decimal", this.PropertyPath<AllValues>(x => x.ArrayValues.Decimal));
            Assert.Equal("ArrayValues.Uint", this.PropertyPath<AllValues>(x => x.ArrayValues.Uint));
            Assert.Equal("ArrayValues.DateTime", this.PropertyPath<AllValues>(x => x.ArrayValues.DateTime));
            Assert.Equal("ArrayValues.Guid", this.PropertyPath<AllValues>(x => x.ArrayValues.Guid));
            Assert.Equal("ArrayValues.Bool", this.PropertyPath<AllValues>(x => x.ArrayValues.Bool));
        }
    }
}
