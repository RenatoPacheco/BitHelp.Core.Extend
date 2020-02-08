using Xunit;
using System;
using System.Linq.Expressions;

namespace BitHelp.Core.Extend.Test.ExpressionExtendTest
{
    public class PropertyTypeTest
    {
        private Type PropertyType<T>(Expression<Func<T, object>> expression)
        {
            return expression.PropertyType();
        }

        [Fact]
        public void Check_property_name()
        {
            Assert.Equal(typeof(char), this.PropertyType<SingleValues>(x => x.Char));
            Assert.Equal(typeof(string), this.PropertyType<SingleValues>(x => x.String));
            Assert.Equal(typeof(int), this.PropertyType<SingleValues>(x => x.Int));
            Assert.Equal(typeof(int?), this.PropertyType<SingleValues>(x => x.IntNull));
            Assert.Equal(typeof(long), this.PropertyType<SingleValues>(x => x.Long));
            Assert.Equal(typeof(long?), this.PropertyType<SingleValues>(x => x.LongNull));
            Assert.Equal(typeof(decimal), this.PropertyType<SingleValues>(x => x.Decimal));
            Assert.Equal(typeof(decimal?), this.PropertyType<SingleValues>(x => x.DecimalNull));
            Assert.Equal(typeof(uint), this.PropertyType<SingleValues>(x => x.Uint));
            Assert.Equal(typeof(uint?), this.PropertyType<SingleValues>(x => x.UintNull));
            Assert.Equal(typeof(DateTime), this.PropertyType<SingleValues>(x => x.DateTime));
            Assert.Equal(typeof(DateTime?), this.PropertyType<SingleValues>(x => x.DateTimeNull));
            Assert.Equal(typeof(Guid), this.PropertyType<SingleValues>(x => x.Guid));
            Assert.Equal(typeof(Guid?), this.PropertyType<SingleValues>(x => x.GuidNull));
            Assert.Equal(typeof(bool), this.PropertyType<SingleValues>(x => x.Bool));
            Assert.Equal(typeof(bool?), this.PropertyType<SingleValues>(x => x.BoolNull));

            Assert.Equal(typeof(char[]), this.PropertyType<ArrayValues>(x => x.Char));
            Assert.Equal(typeof(string[]), this.PropertyType<ArrayValues>(x => x.String));
            Assert.Equal(typeof(int[]), this.PropertyType<ArrayValues>(x => x.Int));
            Assert.Equal(typeof(long[]), this.PropertyType<ArrayValues>(x => x.Long));
            Assert.Equal(typeof(decimal[]), this.PropertyType<ArrayValues>(x => x.Decimal));
            Assert.Equal(typeof(uint[]), this.PropertyType<ArrayValues>(x => x.Uint));
            Assert.Equal(typeof(DateTime[]), this.PropertyType<ArrayValues>(x => x.DateTime));
            Assert.Equal(typeof(Guid[]), this.PropertyType<ArrayValues>(x => x.Guid));
            Assert.Equal(typeof(bool[]), this.PropertyType<ArrayValues>(x => x.Bool));
        }

        [Fact]
        public void Check_property_name_in_subclass()
        {
            Assert.Equal(typeof(int), this.PropertyType<AllValues>(x => x.SingleValues.Int));
            Assert.Equal(typeof(int?), this.PropertyType<AllValues>(x => x.SingleValues.IntNull));
            Assert.Equal(typeof(int[]), this.PropertyType<AllValues>(x => x.ArrayValues.Int));
        }
    }
}
