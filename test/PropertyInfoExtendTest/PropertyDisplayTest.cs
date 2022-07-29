using Xunit;
using System;
using System.Linq.Expressions;
using System.Reflection;

namespace BitHelp.Core.Extend.Test.PropertyInfoExtendTest
{
    public class PropertyDisplayTest
    {
        private static string PropertyDisplay<T>(Expression<Func<T, object>> expression)
        {
            PropertyInfo propertyInfo = expression.PropertyInfo();
            return propertyInfo.PropertyDisplay();
        }

        [Fact]
        public void Check_property_disply()
        {
            SingleValues single = new();
            ArrayValues array = new();

            Assert.Equal(nameof(single.Char), PropertyDisplay<SingleValues>(x => x.Char));
            Assert.Equal(nameof(single.String), PropertyDisplay<SingleValues>(x => x.String));
            Assert.Equal(nameof(single.Int), PropertyDisplay<SingleValues>(x => x.Int));
            Assert.Equal("Int null", PropertyDisplay<SingleValues>(x => x.IntNull));
            Assert.Equal(nameof(single.Long), PropertyDisplay<SingleValues>(x => x.Long));
            Assert.Equal("Long null", PropertyDisplay<SingleValues>(x => x.LongNull));
            Assert.Equal(nameof(single.Decimal), PropertyDisplay<SingleValues>(x => x.Decimal));
            Assert.Equal("Decimal null", PropertyDisplay<SingleValues>(x => x.DecimalNull));
            Assert.Equal(nameof(single.Uint), PropertyDisplay<SingleValues>(x => x.Uint));
            Assert.Equal("Uint null", PropertyDisplay<SingleValues>(x => x.UintNull));
            Assert.Equal("Date time", PropertyDisplay<SingleValues>(x => x.DateTime));
            Assert.Equal("Date time null", PropertyDisplay<SingleValues>(x => x.DateTimeNull));
            Assert.Equal(nameof(single.Guid), PropertyDisplay<SingleValues>(x => x.Guid));
            Assert.Equal("Guid null", PropertyDisplay<SingleValues>(x => x.GuidNull));
            Assert.Equal(nameof(single.Bool), PropertyDisplay<SingleValues>(x => x.Bool));
            Assert.Equal("Bool null", PropertyDisplay<SingleValues>(x => x.BoolNull));

            Assert.Equal("Array char", PropertyDisplay<ArrayValues>(x => x.Char));
            Assert.Equal("Array string", PropertyDisplay<ArrayValues>(x => x.String));
            Assert.Equal("Array int", PropertyDisplay<ArrayValues>(x => x.Int));
            Assert.Equal("Array long", PropertyDisplay<ArrayValues>(x => x.Long));
            Assert.Equal("Array decimal", PropertyDisplay<ArrayValues>(x => x.Decimal));
            Assert.Equal("Array uint", PropertyDisplay<ArrayValues>(x => x.Uint));
            Assert.Equal("Array date time", PropertyDisplay<ArrayValues>(x => x.DateTime));
            Assert.Equal("Array guid", PropertyDisplay<ArrayValues>(x => x.Guid));
            Assert.Equal("Array bool", PropertyDisplay<ArrayValues>(x => x.Bool));
        }

        [Fact]
        public void Check_property_display_in_subclass()
        {
            Assert.Equal("String", PropertyDisplay<AllValues>(x => x.SingleValues.String));
            Assert.Equal("Int null", PropertyDisplay<AllValues>(x => x.SingleValues.IntNull));
            Assert.Equal("Array string", PropertyDisplay<AllValues>(x => x.ArrayValues.String));
        }
    }
}
