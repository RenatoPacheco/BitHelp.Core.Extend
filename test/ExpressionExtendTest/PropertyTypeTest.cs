using Xunit;
using System;
using System.Linq.Expressions;

namespace BitHelp.Core.Extend.Test.ExpressionExtendTest
{
    public class PropertyTypeTest
    {
        private static Type PropertyType<T>(Expression<Func<T, object>> expression)
        {
            return expression.PropertyType();
        }

        [Fact]
        public void Check_property_name()
        {
            Assert.Equal(typeof(char), PropertyType<SingleValues>(x => x.Char));
            Assert.Equal(typeof(string), PropertyType<SingleValues>(x => x.String));
            Assert.Equal(typeof(int), PropertyType<SingleValues>(x => x.Int));
            Assert.Equal(typeof(int?), PropertyType<SingleValues>(x => x.IntNull));
            Assert.Equal(typeof(long), PropertyType<SingleValues>(x => x.Long));
            Assert.Equal(typeof(long?), PropertyType<SingleValues>(x => x.LongNull));
            Assert.Equal(typeof(decimal), PropertyType<SingleValues>(x => x.Decimal));
            Assert.Equal(typeof(decimal?), PropertyType<SingleValues>(x => x.DecimalNull));
            Assert.Equal(typeof(uint), PropertyType<SingleValues>(x => x.Uint));
            Assert.Equal(typeof(uint?), PropertyType<SingleValues>(x => x.UintNull));
            Assert.Equal(typeof(DateTime), PropertyType<SingleValues>(x => x.DateTime));
            Assert.Equal(typeof(DateTime?), PropertyType<SingleValues>(x => x.DateTimeNull));
            Assert.Equal(typeof(Guid), PropertyType<SingleValues>(x => x.Guid));
            Assert.Equal(typeof(Guid?), PropertyType<SingleValues>(x => x.GuidNull));
            Assert.Equal(typeof(bool), PropertyType<SingleValues>(x => x.Bool));
            Assert.Equal(typeof(bool?), PropertyType<SingleValues>(x => x.BoolNull));

            Assert.Equal(typeof(char[]), PropertyType<ArrayValues>(x => x.Char));
            Assert.Equal(typeof(string[]), PropertyType<ArrayValues>(x => x.String));
            Assert.Equal(typeof(int[]), PropertyType<ArrayValues>(x => x.Int));
            Assert.Equal(typeof(long[]), PropertyType<ArrayValues>(x => x.Long));
            Assert.Equal(typeof(decimal[]), PropertyType<ArrayValues>(x => x.Decimal));
            Assert.Equal(typeof(uint[]), PropertyType<ArrayValues>(x => x.Uint));
            Assert.Equal(typeof(DateTime[]), PropertyType<ArrayValues>(x => x.DateTime));
            Assert.Equal(typeof(Guid[]), PropertyType<ArrayValues>(x => x.Guid));
            Assert.Equal(typeof(bool[]), PropertyType<ArrayValues>(x => x.Bool));
        }

        [Fact]
        public void Check_property_name_in_subclass()
        {
            Assert.Equal(typeof(int), PropertyType<AllValues>(x => x.SingleValues.Int));
            Assert.Equal(typeof(int?), PropertyType<AllValues>(x => x.SingleValues.IntNull));
            Assert.Equal(typeof(int[]), PropertyType<AllValues>(x => x.ArrayValues.Int));
        }
    }
}
