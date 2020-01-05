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
            SingleValues single = new SingleValues();
            ArrayValues array = new ArrayValues();

            Assert.Equal(nameof(single.Char), this.PropertyName<SingleValues>(x => x.Char));
            Assert.Equal(nameof(single.String), this.PropertyName<SingleValues>(x => x.String));
            Assert.Equal(nameof(single.Int), this.PropertyName<SingleValues>(x => x.Int));
            Assert.Equal(nameof(single.IntNull), this.PropertyName<SingleValues>(x => x.IntNull));
            Assert.Equal(nameof(single.Long), this.PropertyName<SingleValues>(x => x.Long));
            Assert.Equal(nameof(single.LongNull), this.PropertyName<SingleValues>(x => x.LongNull));
            Assert.Equal(nameof(single.Decimal), this.PropertyName<SingleValues>(x => x.Decimal));
            Assert.Equal(nameof(single.DecimalNull), this.PropertyName<SingleValues>(x => x.DecimalNull));
            Assert.Equal(nameof(single.Uint), this.PropertyName<SingleValues>(x => x.Uint));
            Assert.Equal(nameof(single.UintNull), this.PropertyName<SingleValues>(x => x.UintNull));
            Assert.Equal(nameof(single.DateTime), this.PropertyName<SingleValues>(x => x.DateTime));
            Assert.Equal(nameof(single.DateTimeNull), this.PropertyName<SingleValues>(x => x.DateTimeNull));
            Assert.Equal(nameof(single.Guid), this.PropertyName<SingleValues>(x => x.Guid));
            Assert.Equal(nameof(single.GuidNull), this.PropertyName<SingleValues>(x => x.GuidNull));
            Assert.Equal(nameof(single.Bool), this.PropertyName<SingleValues>(x => x.Bool));
            Assert.Equal(nameof(single.BoolNull), this.PropertyName<SingleValues>(x => x.BoolNull));

            Assert.Equal(nameof(array.Char), this.PropertyName<ArrayValues>(x => x.Char));
            Assert.Equal(nameof(array.String), this.PropertyName<ArrayValues>(x => x.String));
            Assert.Equal(nameof(array.Int), this.PropertyName<ArrayValues>(x => x.Int));
            Assert.Equal(nameof(array.Long), this.PropertyName<ArrayValues>(x => x.Long));
            Assert.Equal(nameof(array.Decimal), this.PropertyName<ArrayValues>(x => x.Decimal));
            Assert.Equal(nameof(array.Uint), this.PropertyName<ArrayValues>(x => x.Uint));
            Assert.Equal(nameof(array.DateTime), this.PropertyName<ArrayValues>(x => x.DateTime));
            Assert.Equal(nameof(array.Guid), this.PropertyName<ArrayValues>(x => x.Guid));
            Assert.Equal(nameof(array.Bool), this.PropertyName<ArrayValues>(x => x.Bool));
        }

        [Fact]
        public void Check_property_name_in_subclass()
        {
            SingleValues single = new SingleValues();
            ArrayValues array = new ArrayValues();

            Assert.Equal(nameof(single.String), this.PropertyName<AllValues>(x => x.SingleValues.String));
            Assert.Equal(nameof(array.String), this.PropertyName<AllValues>(x => x.ArrayValues.String));
        }
    }
}
