using Xunit;
using System;
using System.Linq.Expressions;
using System.Reflection;

namespace BitHelp.Core.Extend.Test.PrpertyInfoExtendTest
{
    public class PropertyDisplayTest
    {
        private string PropertyDisplay<T>(Expression<Func<T, object>> expression)
        {
            PropertyInfo propertyInfo = expression.PropertyInfo();
            return propertyInfo.PropertyDisplay();
        }

        [Fact]
        public void Check_property_disply()
        {
            SingleValues single = new SingleValues();
            ArrayValues array = new ArrayValues();

            Assert.Equal(nameof(single.Char), this.PropertyDisplay<SingleValues>(x => x.Char));
            Assert.Equal(nameof(single.String), this.PropertyDisplay<SingleValues>(x => x.String));
            Assert.Equal(nameof(single.Int), this.PropertyDisplay<SingleValues>(x => x.Int));
            Assert.Equal("Int null", this.PropertyDisplay<SingleValues>(x => x.IntNull));
            Assert.Equal(nameof(single.Long), this.PropertyDisplay<SingleValues>(x => x.Long));
            Assert.Equal("Long null", this.PropertyDisplay<SingleValues>(x => x.LongNull));
            Assert.Equal(nameof(single.Decimal), this.PropertyDisplay<SingleValues>(x => x.Decimal));
            Assert.Equal("Decimal null", this.PropertyDisplay<SingleValues>(x => x.DecimalNull));
            Assert.Equal(nameof(single.Uint), this.PropertyDisplay<SingleValues>(x => x.Uint));
            Assert.Equal("Uint null", this.PropertyDisplay<SingleValues>(x => x.UintNull));
            Assert.Equal("Date time", this.PropertyDisplay<SingleValues>(x => x.DateTime));
            Assert.Equal("Date time null", this.PropertyDisplay<SingleValues>(x => x.DateTimeNull));
            Assert.Equal(nameof(single.Guid), this.PropertyDisplay<SingleValues>(x => x.Guid));
            Assert.Equal("Guid null", this.PropertyDisplay<SingleValues>(x => x.GuidNull));
            Assert.Equal(nameof(single.Bool), this.PropertyDisplay<SingleValues>(x => x.Bool));
            Assert.Equal("Bool null", this.PropertyDisplay<SingleValues>(x => x.BoolNull));

            Assert.Equal("Array char", this.PropertyDisplay<ArrayValues>(x => x.Char));
            Assert.Equal("Array string", this.PropertyDisplay<ArrayValues>(x => x.String));
            Assert.Equal("Array int", this.PropertyDisplay<ArrayValues>(x => x.Int));
            Assert.Equal("Array long", this.PropertyDisplay<ArrayValues>(x => x.Long));
            Assert.Equal("Array decimal", this.PropertyDisplay<ArrayValues>(x => x.Decimal));
            Assert.Equal("Array uint", this.PropertyDisplay<ArrayValues>(x => x.Uint));
            Assert.Equal("Array date time", this.PropertyDisplay<ArrayValues>(x => x.DateTime));
            Assert.Equal("Array guid", this.PropertyDisplay<ArrayValues>(x => x.Guid));
            Assert.Equal("Array bool", this.PropertyDisplay<ArrayValues>(x => x.Bool));
        }

        [Fact]
        public void Check_property_display_in_subclass()
        {
            Assert.Equal("String", this.PropertyDisplay<AllValues>(x => x.SingleValues.String));
            Assert.Equal("Int null", this.PropertyDisplay<AllValues>(x => x.SingleValues.IntNull));
            Assert.Equal("Array string", this.PropertyDisplay<AllValues>(x => x.ArrayValues.String));
        }
    }
}
