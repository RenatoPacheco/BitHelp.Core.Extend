using Xunit;
using System;
using System.Linq.Expressions;

namespace BitHelp.Core.Extend.Test.ExpressionExtendTest
{
    public class PropertyTrailTest
    {
        private string PropertyTrail<T>(Expression<Func<T, object>> expressao)
        {
            return expressao.PropertyTrail();
        }

        [Fact]
        public void Check_property_trail()
        {
            SingleValues singles = new SingleValues();
            ArrayValues arrays = new ArrayValues();

            Assert.Equal(nameof(singles.String), this.PropertyTrail<SingleValues>(x => x.String));
            Assert.Equal(nameof(singles.Int), this.PropertyTrail<SingleValues>(x => x.Int));
            Assert.Equal(nameof(singles.IntNull), this.PropertyTrail<SingleValues>(x => x.IntNull));
            Assert.Equal(nameof(singles.Long), this.PropertyTrail<SingleValues>(x => x.Long));
            Assert.Equal(nameof(singles.LongNull), this.PropertyTrail<SingleValues>(x => x.LongNull));
            Assert.Equal(nameof(singles.Decimal), this.PropertyTrail<SingleValues>(x => x.Decimal));
            Assert.Equal(nameof(singles.DecimalNull), this.PropertyTrail<SingleValues>(x => x.DecimalNull));
            Assert.Equal(nameof(singles.Uint), this.PropertyTrail<SingleValues>(x => x.Uint));
            Assert.Equal(nameof(singles.UintNull), this.PropertyTrail<SingleValues>(x => x.UintNull));
            Assert.Equal(nameof(singles.DateTime), this.PropertyTrail<SingleValues>(x => x.DateTime));
            Assert.Equal(nameof(singles.DateTimeNull), this.PropertyTrail<SingleValues>(x => x.DateTimeNull));
            Assert.Equal(nameof(singles.Guid), this.PropertyTrail<SingleValues>(x => x.Guid));
            Assert.Equal(nameof(singles.GuidNull), this.PropertyTrail<SingleValues>(x => x.GuidNull));
            Assert.Equal(nameof(singles.Bool), this.PropertyTrail<SingleValues>(x => x.Bool));
            Assert.Equal(nameof(singles.BoolNull), this.PropertyTrail<SingleValues>(x => x.BoolNull));

            Assert.Equal(nameof(arrays.String), this.PropertyTrail<ArrayValues>(x => x.String));
            Assert.Equal(nameof(arrays.Int), this.PropertyTrail<ArrayValues>(x => x.Int));
            Assert.Equal(nameof(arrays.Long), this.PropertyTrail<ArrayValues>(x => x.Long));
            Assert.Equal(nameof(arrays.Decimal), this.PropertyTrail<ArrayValues>(x => x.Decimal));
            Assert.Equal(nameof(arrays.Uint), this.PropertyTrail<ArrayValues>(x => x.Uint));
            Assert.Equal(nameof(arrays.DateTime), this.PropertyTrail<ArrayValues>(x => x.DateTime));
            Assert.Equal(nameof(arrays.Guid), this.PropertyTrail<ArrayValues>(x => x.Guid));
            Assert.Equal(nameof(arrays.Bool), this.PropertyTrail<ArrayValues>(x => x.Bool));
        }

        [Fact]
        public void Check_property_trail_in_subclass()
        {
            Assert.Equal("SingleValues.String", this.PropertyTrail<AllValues>(x => x.SingleValues.String));
            Assert.Equal("SingleValues.Int", this.PropertyTrail<AllValues>(x => x.SingleValues.Int));
            Assert.Equal("SingleValues.IntNull", this.PropertyTrail<AllValues>(x => x.SingleValues.IntNull));
            Assert.Equal("SingleValues.Long", this.PropertyTrail<AllValues>(x => x.SingleValues.Long));
            Assert.Equal("SingleValues.LongNull", this.PropertyTrail<AllValues>(x => x.SingleValues.LongNull));
            Assert.Equal("SingleValues.Decimal", this.PropertyTrail<AllValues>(x => x.SingleValues.Decimal));
            Assert.Equal("SingleValues.DecimalNull", this.PropertyTrail<AllValues>(x => x.SingleValues.DecimalNull));
            Assert.Equal("SingleValues.Uint", this.PropertyTrail<AllValues>(x => x.SingleValues.Uint));
            Assert.Equal("SingleValues.UintNull", this.PropertyTrail<AllValues>(x => x.SingleValues.UintNull));
            Assert.Equal("SingleValues.DateTime", this.PropertyTrail<AllValues>(x => x.SingleValues.DateTime));
            Assert.Equal("SingleValues.DateTimeNull", this.PropertyTrail<AllValues>(x => x.SingleValues.DateTimeNull));
            Assert.Equal("SingleValues.Guid", this.PropertyTrail<AllValues>(x => x.SingleValues.Guid));
            Assert.Equal("SingleValues.GuidNull", this.PropertyTrail<AllValues>(x => x.SingleValues.GuidNull));
            Assert.Equal("SingleValues.Bool", this.PropertyTrail<AllValues>(x => x.SingleValues.Bool));
            Assert.Equal("SingleValues.BoolNull", this.PropertyTrail<AllValues>(x => x.SingleValues.BoolNull));

            Assert.Equal("ArrayValues.String", this.PropertyTrail<AllValues>(x => x.ArrayValues.String));
            Assert.Equal("ArrayValues.Int", this.PropertyTrail<AllValues>(x => x.ArrayValues.Int));
            Assert.Equal("ArrayValues.Long", this.PropertyTrail<AllValues>(x => x.ArrayValues.Long));
            Assert.Equal("ArrayValues.Decimal", this.PropertyTrail<AllValues>(x => x.ArrayValues.Decimal));
            Assert.Equal("ArrayValues.Uint", this.PropertyTrail<AllValues>(x => x.ArrayValues.Uint));
            Assert.Equal("ArrayValues.DateTime", this.PropertyTrail<AllValues>(x => x.ArrayValues.DateTime));
            Assert.Equal("ArrayValues.Guid", this.PropertyTrail<AllValues>(x => x.ArrayValues.Guid));
            Assert.Equal("ArrayValues.Bool", this.PropertyTrail<AllValues>(x => x.ArrayValues.Bool));
        }
    }
}
