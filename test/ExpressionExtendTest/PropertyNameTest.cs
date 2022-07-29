using Xunit;
using System;
using System.Linq.Expressions;

namespace BitHelp.Core.Extend.Test.ExpressionExtendTest
{
    public class PropertyNameTest
    {
        private static string PropertyName<T>(Expression<Func<T, object>> expression)
        {
            return expression.PropertyName();
        }

        [Fact]
        public void Check_property_name()
        {
            SingleValues single = new SingleValues();
            ArrayValues array = new ArrayValues();

            Assert.Equal(nameof(single.Char), PropertyName<SingleValues>(x => x.Char));
            Assert.Equal(nameof(single.String), PropertyName<SingleValues>(x => x.String));
            Assert.Equal(nameof(single.Int), PropertyName<SingleValues>(x => x.Int));
            Assert.Equal(nameof(single.IntNull), PropertyName<SingleValues>(x => x.IntNull));
            Assert.Equal(nameof(single.Long), PropertyName<SingleValues>(x => x.Long));
            Assert.Equal(nameof(single.LongNull), PropertyName<SingleValues>(x => x.LongNull));
            Assert.Equal(nameof(single.Decimal), PropertyName<SingleValues>(x => x.Decimal));
            Assert.Equal(nameof(single.DecimalNull), PropertyName<SingleValues>(x => x.DecimalNull));
            Assert.Equal(nameof(single.Uint), PropertyName<SingleValues>(x => x.Uint));
            Assert.Equal(nameof(single.UintNull), PropertyName<SingleValues>(x => x.UintNull));
            Assert.Equal(nameof(single.DateTime), PropertyName<SingleValues>(x => x.DateTime));
            Assert.Equal(nameof(single.DateTimeNull), PropertyName<SingleValues>(x => x.DateTimeNull));
            Assert.Equal(nameof(single.Guid), PropertyName<SingleValues>(x => x.Guid));
            Assert.Equal(nameof(single.GuidNull), PropertyName<SingleValues>(x => x.GuidNull));
            Assert.Equal(nameof(single.Bool), PropertyName<SingleValues>(x => x.Bool));
            Assert.Equal(nameof(single.BoolNull), PropertyName<SingleValues>(x => x.BoolNull));

            Assert.Equal(nameof(array.Char), PropertyName<ArrayValues>(x => x.Char));
            Assert.Equal(nameof(array.String), PropertyName<ArrayValues>(x => x.String));
            Assert.Equal(nameof(array.Int), PropertyName<ArrayValues>(x => x.Int));
            Assert.Equal(nameof(array.Long), PropertyName<ArrayValues>(x => x.Long));
            Assert.Equal(nameof(array.Decimal), PropertyName<ArrayValues>(x => x.Decimal));
            Assert.Equal(nameof(array.Uint), PropertyName<ArrayValues>(x => x.Uint));
            Assert.Equal(nameof(array.DateTime), PropertyName<ArrayValues>(x => x.DateTime));
            Assert.Equal(nameof(array.Guid), PropertyName<ArrayValues>(x => x.Guid));
            Assert.Equal(nameof(array.Bool), PropertyName<ArrayValues>(x => x.Bool));
        }

        [Fact]
        public void Check_property_name_in_subclass()
        {
            SingleValues single = new SingleValues();
            ArrayValues array = new ArrayValues();

            Assert.Equal(nameof(single.String), PropertyName<AllValues>(x => x.SingleValues.String));
            Assert.Equal(nameof(array.String), PropertyName<AllValues>(x => x.ArrayValues.String));
        }
    }
}
