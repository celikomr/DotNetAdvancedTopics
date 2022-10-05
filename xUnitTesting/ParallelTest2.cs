using System.Threading;
using Xunit;

namespace xUnitTesting
{
    public class ParallelTest2 //test1 ve test2 paralel olarak çalışır. toplam süre 5 sn sürer. collection tag eklenirse, sıralı olarak çalıştırılır
    {
        //[Collection("Test Collection #1")]
        public class TestClass1
        {
            [Fact]
            public void Test1()
            {
                Thread.Sleep(5000);
            }
        }

        //[Collection("Test Collection #1")]
        public class TestClass2
        {
            [Fact]
            public void Test2()
            {
                Thread.Sleep(3000);
            }
        }
    }
}