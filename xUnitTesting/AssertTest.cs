using System.Collections.Generic;
using Xunit;

namespace xUnitTesting
{
    public class AssertTest  //FonksiyonAdı_BeklenenDeger_GecilecekParametre  test fonksiyonu isimlendirme
    {
        [Fact]
        public void Assert_Contains()
        {
            Assert.Contains("text", "This is a text.");

            var names = new List<string> { "Conceptwave", "Maestro" };

            Assert.Contains(names, n => n == "Maestro");

            Assert.DoesNotContain("sdf", "This is a text.");
        }

        [Fact(Skip = "Skip denemesi")]
        public void Assert_Bool()
        {
            //Assert.True("".GetType() == typeof(string));
            Assert.False(1.GetType() == typeof(int));
        }

        [Fact]
        [Trait("Assert", "Operations")]
        public void Assert_Match()
        {
            var regEx = @"\A[A-Z0-9+_.-]+@[A-Z0-9.-]+\Z";
            Assert.DoesNotMatch(regEx, "this is a text");
            //Assert.Matches(regEx, "this is a text");
        }

        [Fact]
        [Trait("Assert", "Operations")]
        public void Assert_Starts_Ends()
        {
            Assert.StartsWith("This", "This is a text.");
            Assert.EndsWith("text.", "This is a text.");
        }

        [Fact]
        [Trait("Assert", "Other Assert Types")]
        public void Assert_Others()
        {
            //Assert.Equal("text", "Text");
            Assert.NotEqual("text", "Text");

            Assert.Empty(new List<int> { });
            //Assert.NotEmpty(new List<int> { 1 });

            Assert.InRange(3, 1, 6);
            //Assert.NotInRange(3, 1, 2);

            var listWithSingle = new List<int> { 1 };
            Assert.Single(listWithSingle);
        }
    }
}
