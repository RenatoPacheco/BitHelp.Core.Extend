using System.Linq;
using Xunit;

namespace BitHelp.Core.Extend.Test.LinqExtend
{
    public class IEnumerableDistictByTest
    {
        [Fact]
        public void Check_distinct_itens()
        {
            SingleValues[] list = new SingleValues[]
            {
                new SingleValues { String = "Text 1" },
                new SingleValues { String = "Text 2" },
                new SingleValues { String = "Text 3" },
                new SingleValues { String = "Text 1" },
                new SingleValues { String = "Text 4" },
                new SingleValues { String = "Text 2" }
            };

            Assert.Equal(6, list.Length);

            list = list.DistinctBy(x => x.String).ToArray();

            Assert.Equal(4, list.Length);

            list = list.DistinctBy(x => x.Int).ToArray();

            Assert.Single(list);
        }

        [Fact]
        public void Check_distinct_itens_null()
        {
            SingleValues[] list = new SingleValues[]
            {
                new SingleValues { String = "Text 1" },
                new SingleValues { String = "Text 2" },
                new SingleValues { String = "Text 3" },
                new SingleValues { String = "Text 1" },
                new SingleValues { String = "Text 4" },
                new SingleValues { String = "Text 2" }
            };

            Assert.Equal(6, list.Length);

            list = list.DistinctBy(x => x.String).ToArray();

            Assert.Equal(4, list.Length);

            list = list.DistinctBy(x => x.IntNull).ToArray();

            Assert.Single(list);
        }
    }
}
