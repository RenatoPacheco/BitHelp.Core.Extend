using System;
using Xunit;

namespace BitHelp.Core.Extend.Test.ClassExtendTest
{
    public class PropertySetValueTest
    {
        [Fact]
        public void Set_property_public()
        {
            LevelValues level = new LevelValues();
            level.PropertySetValue(x => x.Public, nameof(level.Public));
            Assert.Equal(nameof(level.Public), level.Public);
        }

        [Fact]
        public void Set_property_protected()
        {
            LevelValues level = new LevelValues();
            level.PropertySetValue(x => x.Protected, nameof(level.Protected));
            Assert.Equal(nameof(level.Protected), level.Protected);
        }

        [Fact]
        public void Set_property_internal()
        {
            LevelValues level = new LevelValues();
            level.PropertySetValue(x => x.Internal, nameof(level.Internal));
            Assert.Equal(nameof(level.Internal), level.Internal);
        }

        [Fact]
        public void Set_property_protected_internal()
        {
            LevelValues level = new LevelValues();
            level.PropertySetValue(x => x.ProtectedInternal, nameof(level.ProtectedInternal));
            Assert.Equal(nameof(level.ProtectedInternal), level.ProtectedInternal);
        }

        [Fact]
        public void Set_property_private()
        {
            LevelValues level = new LevelValues();
            level.PropertySetValue(x => x.Private, nameof(level.Private));
            Assert.Equal(nameof(level.Private), level.Private);
        }

        [Fact]
        public void Set_property_protected_private()
        {
            LevelValues level = new LevelValues();
            level.PropertySetValue(x => x.ProtectedPrivate, nameof(level.ProtectedPrivate));
            Assert.Equal(nameof(level.ProtectedPrivate), level.ProtectedPrivate);
        }

        [Fact]
        public void Set_property_sub_level_public()
        {
            LevelValues level = new LevelValues();
            level.SubLevel = new LevelValues();

            level.PropertySetValue(x => x.SubLevel.Public, nameof(level.Public));
            Assert.Equal(nameof(level.Public), level.SubLevel.Public);
        }

        [Fact]
        public void Set_property_sub_level_protected()
        {
            LevelValues level = new LevelValues();
            level.SubLevel = new LevelValues();

            level.PropertySetValue(x => x.SubLevel.Protected, nameof(level.Protected));
            Assert.Equal(nameof(level.Protected), level.SubLevel.Protected);
        }

        [Fact]
        public void Set_property_sub_level_internal()
        {
            LevelValues level = new LevelValues();
            level.SubLevel = new LevelValues();

            level.PropertySetValue(x => x.SubLevel.Internal, nameof(level.Internal));
            Assert.Equal(nameof(level.Internal), level.SubLevel.Internal);
        }

        [Fact]
        public void Set_property_sub_level_private()
        {
            LevelValues level = new LevelValues();
            level.SubLevel = new LevelValues();

            level.PropertySetValue(x => x.SubLevel.Private, nameof(level.Private));
            Assert.Equal(nameof(level.Private), level.SubLevel.Private);
        }

        [Fact]
        public void Set_property_sub_level_multiple_properties()
        {
            LevelValues level = new LevelValues();
            level.SubLevel = new LevelValues();

            level.PropertySetValue(x => x.SubLevel.Public, nameof(level.Public));
            level.PropertySetValue(x => x.SubLevel.Protected, nameof(level.Protected));
            level.PropertySetValue(x => x.SubLevel.Internal, nameof(level.Internal));
            level.PropertySetValue(x => x.SubLevel.ProtectedInternal, nameof(level.ProtectedInternal));
            level.PropertySetValue(x => x.SubLevel.Private, nameof(level.Private));
            level.PropertySetValue(x => x.SubLevel.ProtectedPrivate, nameof(level.ProtectedPrivate));

            Assert.Equal(nameof(level.Public), level.SubLevel.Public);
            Assert.Equal(nameof(level.Protected), level.SubLevel.Protected);
            Assert.Equal(nameof(level.Internal), level.SubLevel.Internal);
            Assert.Equal(nameof(level.ProtectedInternal), level.SubLevel.ProtectedInternal);
            Assert.Equal(nameof(level.Private), level.SubLevel.Private);
            Assert.Equal(nameof(level.ProtectedPrivate), level.SubLevel.ProtectedPrivate);
        }

        [Fact]
        public void Set_property_single()
        {
            SingleValues single = new SingleValues();
            DateTime date = DateTime.Now;
            Guid guid = Guid.NewGuid();

            single.PropertySetValue(x => x.Char, 'a');
            Assert.Equal('a', single.Char);

            single.PropertySetValue(x => x.String, "test");
            Assert.Equal("test", single.String);

            single.PropertySetValue(x => x.Int, 10);
            Assert.Equal(10, single.Int);

            single.PropertySetValue(x => x.IntNull, 10);
            Assert.Equal(10, single.IntNull);

            single.PropertySetValue(x => x.Long, 10);
            Assert.Equal(10, single.Long);

            single.PropertySetValue(x => x.LongNull, 10);
            Assert.Equal(10, single.LongNull);

            single.PropertySetValue(x => x.Decimal, 10);
            Assert.Equal(10, single.Decimal);

            single.PropertySetValue(x => x.DecimalNull, 10);
            Assert.Equal(10, single.DecimalNull);

            single.PropertySetValue(x => x.Uint, (uint)10);
            Assert.Equal((uint)10, single.Uint);

            single.PropertySetValue(x => x.UintNull, (uint)10);
            Assert.Equal((uint)10, single.UintNull);

            single.PropertySetValue(x => x.DateTime, date);
            Assert.Equal(date, single.DateTime);

            single.PropertySetValue(x => x.DateTimeNull, date);
            Assert.Equal(date, single.DateTimeNull);

            single.PropertySetValue(x => x.Guid, guid);
            Assert.Equal(guid, single.Guid);

            single.PropertySetValue(x => x.GuidNull, guid);
            Assert.Equal(guid, single.GuidNull);

            single.PropertySetValue(x => x.Bool, true);
            Assert.True(single.Bool);

            single.PropertySetValue(x => x.BoolNull, true);
            Assert.True(single.BoolNull);
        }
    }
}
