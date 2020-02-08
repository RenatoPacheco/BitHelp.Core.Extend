using System;
using Xunit;

namespace BitHelp.Core.Extend.Test.ClassExtendTest
{
    public class PropertyGetValueTest
    {
        [Fact]
        public void Get_property_public()
        {
            LevelValues level = new LevelValues();
            string value = $"value: {nameof(level.Public)}";

            level.PropertySetValue(x => x.Public, value);
            Assert.Equal(value, level.PropertyGetValue(x => x.Public));
        }

        [Fact]
        public void Get_property_protected()
        {
            LevelValues level = new LevelValues();
            string value = $"value: {nameof(level.Protected)}";

            level.PropertySetValue(x => x.Protected, value);
            Assert.Equal(value, level.PropertyGetValue(x => x.Protected));
        }

        [Fact]
        public void Get_property_internal()
        {
            LevelValues level = new LevelValues();
            string value = $"value: {nameof(level.Internal)}";

            level.PropertySetValue(x => x.Internal, value);
            Assert.Equal(value, level.PropertyGetValue(x => x.Internal));
        }

        [Fact]
        public void Get_property_protected_internal()
        {
            LevelValues level = new LevelValues();
            string value = $"value: {nameof(level.ProtectedInternal)}";

            level.PropertySetValue(x => x.ProtectedInternal, value);
            Assert.Equal(value, level.PropertyGetValue(x => x.ProtectedInternal));
        }

        [Fact]
        public void Get_property_private()
        {
            LevelValues level = new LevelValues();
            string value = $"value: {nameof(level.Private)}";

            level.PropertySetValue(x => x.Private, value);
            Assert.Equal(value, level.PropertyGetValue(x => x.Private));
        }

        [Fact]
        public void Get_property_protected_private()
        {
            LevelValues level = new LevelValues();
            string value = $"value: {nameof(level.ProtectedPrivate)}";

            level.PropertySetValue(x => x.ProtectedPrivate, value);
            Assert.Equal(value, level.PropertyGetValue(x => x.ProtectedPrivate));
        }

        [Fact]
        public void Get_property_sub_level_public()
        {
            LevelValues level = new LevelValues
            {
                SubLevel = new LevelValues()
            };
            string value = $"value level: {nameof(level.Public)}";

            level.PropertySetValue(x => x.SubLevel.Public, value);
            Assert.Equal(value, level.PropertyGetValue(x => x.SubLevel.Public));
        }

        [Fact]
        public void Get_property_sub_level_protected()
        {
            LevelValues level = new LevelValues
            {
                SubLevel = new LevelValues()
            };
            string value = $"value level: {nameof(level.Protected)}";

            level.PropertySetValue(x => x.SubLevel.Protected, value);
            Assert.Equal(value, level.PropertyGetValue(x => x.SubLevel.Protected));
        }

        [Fact]
        public void Get_property_sub_level_internal()
        {
            LevelValues level = new LevelValues
            {
                SubLevel = new LevelValues()
            };
            string value = $"value level: {nameof(level.Internal)}";

            level.PropertySetValue(x => x.SubLevel.Internal, value);
            Assert.Equal(value, level.PropertyGetValue(x => x.SubLevel.Internal));
        }

        [Fact]
        public void Get_property_sub_level_private()
        {
            LevelValues level = new LevelValues
            {
                SubLevel = new LevelValues()
            };
            string value = $"value level: {nameof(level.Private)}";

            level.PropertySetValue(x => x.SubLevel.Private, value);
            Assert.Equal(value, level.PropertyGetValue(x => x.SubLevel.Private));
        }

        [Fact]
        public void Get_property_single()
        {
            SingleValues single = new SingleValues();
            DateTime date = DateTime.Now;
            Guid guid = Guid.NewGuid();

            single.PropertySetValue(x => x.Char, 'a');
            Assert.Equal('a', single.PropertyGetValue(x => x.Char));

            single.PropertySetValue(x => x.String, "test");
            Assert.Equal("test", single.PropertyGetValue(x => x.String));

            single.PropertySetValue(x => x.Int, 10);
            Assert.Equal(10, single.PropertyGetValue(x => x.Int));

            single.PropertySetValue(x => x.IntNull, 10);
            Assert.Equal(10, single.PropertyGetValue(x => x.IntNull));

            single.PropertySetValue(x => x.Long, 10);
            Assert.Equal(10, (long)single.PropertyGetValue(x => x.Long));

            single.PropertySetValue(x => x.LongNull, 10);
            Assert.Equal(10, (long)single.PropertyGetValue(x => x.LongNull));

            single.PropertySetValue(x => x.Decimal, 10);
            Assert.Equal(10, (decimal)single.PropertyGetValue(x => x.Decimal));

            single.PropertySetValue(x => x.DecimalNull, 10);
            Assert.Equal(10, (decimal)single.PropertyGetValue(x => x.DecimalNull));

            single.PropertySetValue(x => x.Uint, (uint)10);
            Assert.Equal((uint)10, (uint)single.PropertyGetValue(x => x.Uint));

            single.PropertySetValue(x => x.UintNull, (uint)10);
            Assert.Equal((uint)10, (uint)single.PropertyGetValue(x => x.UintNull));

            single.PropertySetValue(x => x.DateTime, date);
            Assert.Equal(date, single.PropertyGetValue(x => x.DateTime));

            single.PropertySetValue(x => x.DateTimeNull, date);
            Assert.Equal(date, single.PropertyGetValue(x => x.DateTimeNull));

            single.PropertySetValue(x => x.Guid, guid);
            Assert.Equal(guid, single.PropertyGetValue(x => x.Guid));

            single.PropertySetValue(x => x.GuidNull, guid);
            Assert.Equal(guid, single.PropertyGetValue(x => x.GuidNull));

            single.PropertySetValue(x => x.Bool, true);
            Assert.Equal(true, single.PropertyGetValue(x => x.Bool));

            single.PropertySetValue(x => x.BoolNull, true);
            Assert.Equal(true, single.PropertyGetValue(x => x.BoolNull));
        }
    }
}
