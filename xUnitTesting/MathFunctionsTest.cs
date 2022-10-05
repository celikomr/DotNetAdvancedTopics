using xUnitTesting.Helpers;

namespace xUnitTesting
{
    public class MathFunctionsTest
    {
        [Fact]
        public void Add_ShouldAssertTrue_WhenSumTwoNumbers()
        {
            // Arrange
            var a = 1;
            var b = 2;

            // Act
            var result = a + b;

            // Assert
            Assert.Equal(3, result);
        }

        [Fact]
        public void AddString_ShouldBeNotNull_WhenSumTwoNumbers()
        {
            // Arrange
            var a = "1";
            var b = "2";

            // Act
            var result = a + b;

            // Assert
            Assert.NotNull(result);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(-4, -6, -10)]
        [InlineData(-2, 2, 0)]
        public void Add_ShouldAssertTrue_WhenSumTwoNumbers_DataDriven(int a, int b, int expectedResult)
        {

            // Act
            var actualResult = a+ b;

            // Assert
            Assert.Equal(expectedResult, actualResult);

        }

        [Theory]
        [JsonFileData("data.json", "AddData")]
        public void Add_ShouldAssertTrue_WhenSumTwoNumbers_JsonFile(int a, int b, int expectedResult)
        {
            
            // Act
            var actualResult = a + b;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [JsonFileData("data.json", "SubtractData")]
        public void Subtract_ShouldAssertTrue_WhenSubTwoNumbers_JsonFile(int a, int b, int expectedResult)
        {

            // Act
            var actualResult = a - b;

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}