using Xunit;
using System;
using System.Collections.Generic;

namespace BitHelp.Core.Extend.Test.TypeExtendTest
{
    public class IsListTest
    {
        [Fact]
        public void Check_array_is_list()
        {
            Assert.True(typeof(char[]).IsList());
            Assert.True(typeof(string[]).IsList());
            Assert.True(typeof(int[]).IsList());
            Assert.True(typeof(long[]).IsList());
            Assert.True(typeof(decimal[]).IsList());
            Assert.True(typeof(uint[]).IsList());
            Assert.True(typeof(Guid[]).IsList());
            Assert.True(typeof(DateTime[]).IsList());
            Assert.True(typeof(bool[]).IsList());
            Assert.True(typeof(SingleValues[]).IsList());
        }

        [Fact]
        public void Check_ilist_is_list()
        {
            Assert.True(typeof(IList<char>).IsList());
            Assert.True(typeof(IList<string>).IsList());
            Assert.True(typeof(IList<int>).IsList());
            Assert.True(typeof(IList<long>).IsList());
            Assert.True(typeof(IList<decimal>).IsList());
            Assert.True(typeof(IList<uint>).IsList());
            Assert.True(typeof(IList<Guid>).IsList());
            Assert.True(typeof(IList<DateTime>).IsList());
            Assert.True(typeof(IList<bool>).IsList());
            Assert.True(typeof(IList<SingleValues>).IsList());
        }

        [Fact]
        public void Check_ienumerable_is_list()
        {
            Assert.True(typeof(IEnumerable<char>).IsList());
            Assert.True(typeof(IEnumerable<string>).IsList());
            Assert.True(typeof(IEnumerable<int>).IsList());
            Assert.True(typeof(IEnumerable<long>).IsList());
            Assert.True(typeof(IEnumerable<decimal>).IsList());
            Assert.True(typeof(IEnumerable<uint>).IsList());
            Assert.True(typeof(IEnumerable<Guid>).IsList());
            Assert.True(typeof(IEnumerable<DateTime>).IsList());
            Assert.True(typeof(IEnumerable<bool>).IsList());
            Assert.True(typeof(IEnumerable<SingleValues>).IsList());
        }

        [Fact]
        public void Check_single_is_not_list()
        {
            Assert.False(typeof(char).IsList());
            Assert.False(typeof(string).IsList());
            Assert.False(typeof(int).IsList());
            Assert.False(typeof(long).IsList());
            Assert.False(typeof(decimal).IsList());
            Assert.False(typeof(uint).IsList());
            Assert.False(typeof(Guid).IsList());
            Assert.False(typeof(DateTime).IsList());
            Assert.False(typeof(bool).IsList());
            Assert.False(typeof(SingleValues).IsList());
        }
    }
}
