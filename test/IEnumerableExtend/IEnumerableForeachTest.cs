using System.Linq;
using Xunit;

namespace BitHelp.Core.Extend.Test.LinqExtend
{
    public class IEnumerableForeachTest
    {
        [Fact]
        public void Check_foreach_itens()
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

            int count = 0;

            Assert.Equal(6, list.Length);

            list.ForEach((item) => {
                item.String = $"Text {count}";
                count++;
            });

            list = list.DistinctBy(x => x.String).ToArray();

            Assert.Equal(6, list.Length);

            list = list.DistinctBy(x => x.Int).ToArray();

            Assert.Single(list);
        }
    }
}
