using Xunit;
using System;
using System.Linq.Expressions;

namespace BitHelp.Core.Extend.Test.ExpressionExtendTest
{
    public class PropertyNameTest
    {
        private string PropertyName<T>(Expression<Func<T, object>> expressao)
        {
            return expressao.PropertyName();
        }

        [Fact]
        public void Check_property_name()
        {
            SingleValues singles = new SingleValues();
            ArrayValues arrays = new ArrayValues();

            Assert.Equal(nameof(singles.Char), this.PropertyName<SingleValues>(x => x.Char));
            Assert.Equal(nameof(singles.String), this.PropertyName<SingleValues>(x => x.String));
            Assert.Equal(nameof(singles.Int), this.PropertyName<SingleValues>(x => x.Int));
            Assert.Equal(nameof(singles.IntNull), this.PropertyName<SingleValues>(x => x.IntNull));
            Assert.Equal(nameof(singles.Long), this.PropertyName<SingleValues>(x => x.Long));
            Assert.Equal(nameof(singles.LongNull), this.PropertyName<SingleValues>(x => x.LongNull));
            Assert.Equal(nameof(singles.Decimal), this.PropertyName<SingleValues>(x => x.Decimal));
            Assert.Equal(nameof(singles.DecimalNull), this.PropertyName<SingleValues>(x => x.DecimalNull));
            Assert.Equal(nameof(singles.Uint), this.PropertyName<SingleValues>(x => x.Uint));
            Assert.Equal(nameof(singles.UintNull), this.PropertyName<SingleValues>(x => x.UintNull));
            Assert.Equal(nameof(singles.DateTime), this.PropertyName<SingleValues>(x => x.DateTime));
            Assert.Equal(nameof(singles.DateTimeNull), this.PropertyName<SingleValues>(x => x.DateTimeNull));
            Assert.Equal(nameof(singles.Guid), this.PropertyName<SingleValues>(x => x.Guid));
            Assert.Equal(nameof(singles.GuidNull), this.PropertyName<SingleValues>(x => x.GuidNull));
            Assert.Equal(nameof(singles.Bool), this.PropertyName<SingleValues>(x => x.Bool));
            Assert.Equal(nameof(singles.BoolNull), this.PropertyName<SingleValues>(x => x.BoolNull));

            Assert.Equal(nameof(arrays.Char), this.PropertyName<ArrayValues>(x => x.Char));
            Assert.Equal(nameof(arrays.String), this.PropertyName<ArrayValues>(x => x.String));
            Assert.Equal(nameof(arrays.Int), this.PropertyName<ArrayValues>(x => x.Int));
            Assert.Equal(nameof(arrays.Long), this.PropertyName<ArrayValues>(x => x.Long));
            Assert.Equal(nameof(arrays.Decimal), this.PropertyName<ArrayValues>(x => x.Decimal));
            Assert.Equal(nameof(arrays.Uint), this.PropertyName<ArrayValues>(x => x.Uint));
            Assert.Equal(nameof(arrays.DateTime), this.PropertyName<ArrayValues>(x => x.DateTime));
            Assert.Equal(nameof(arrays.Guid), this.PropertyName<ArrayValues>(x => x.Guid));
            Assert.Equal(nameof(arrays.Bool), this.PropertyName<ArrayValues>(x => x.Bool));
        }

        [Fact]
        public void Check_property_name_in_subclass()
        {
            SingleValues singles = new SingleValues();
            ArrayValues arrays = new ArrayValues();
            AllValues all = new AllValues();

            Assert.Equal(nameof(singles.String), this.PropertyName<AllValues>(x => x.SingleValues.String));
            Assert.Equal(nameof(arrays.String), this.PropertyName<AllValues>(x => x.ArrayValues.String));
        }
    }
}
