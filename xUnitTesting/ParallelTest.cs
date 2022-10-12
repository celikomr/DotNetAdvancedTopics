using System.Threading;
using Xunit;

namespace xUnitTesting
{      
    public class ParallelTest //önce test1 sonra test2 çalışır. toplam 8 sn sürer, sıralı çalışır
    {
        [Fact]
        public void Test1()
        {
            Thread.Sleep(5000);
        }

        [Fact]
        public void Test2()
        {
            Thread.Sleep(3000);
        }
    }
}
