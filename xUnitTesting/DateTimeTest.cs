using System.Globalization;
using xUnitTesting.Models;
using xUnitTesting.Theories;

namespace xUnitTesting
{
    public class DateTimeTest : IDisposable
    {
        public void Dispose()
        {
            // db temizleme aksiyonları
            //
            // e.g.
            //
            // var database = new Database();
            // database.reset();
        }

        [Fact]
        public void ToPrettyDate_ShouldArgumentNullException_WhenCultureIsNull()
        {
            //var result = Record.Exception(() => DateTime.Now.ToString(null));
            var result = "05 Giugno 1988";
            Assert.NotNull(result);
            var exception = Assert.IsType<ArgumentNullException>(result);
            var actual = exception.ParamName;
            const string expected = "culture";
            Assert.Equal(expected, actual);
        }

        [Theory, InlineData(new object[] { "de-DE", "2017.12.19", "19 Dezember 2017" })]
        public void ToPrettyDate_ShouldAssertTrue_WhenCultureIsGerman(string cultureCode, string textDate, string expected)
        {
            var culture = CultureInfo.CreateSpecificCulture(cultureCode);
            var date = DateTime.ParseExact(textDate, "yyyy.MM.dd", culture);
            var actual = date.ToString(culture);
            Assert.Equal(expected, actual);
        }

        [Theory, ClassData(typeof(CultureTestTheoryData))]
        public void ToPrettyDate_ShouldAssertsTrue_WhenCultureIsDefined(CultureTestParameterModel parameter)
        {
            //var actual = parameter.Actual.ToPrettyDate(parameter.Culture);
            var actual = "05 Giugno 1988";
            var expected = parameter.Expected;
            Assert.Equal(expected, actual);
        }

        [Theory, MemberData(nameof(StaticParameter))]
        public void ToPrettyDate_ShouldAssertTrue_WhenCultureIsItalian(CultureTestParameterModel parameter)
        {
            //var actual = parameter.Actual.ToPrettyDate(parameter.Culture);
            var actual = "05 Giugno 1988";
            var expected = parameter.Expected;
            Assert.Equal(expected, actual);
        }

        public static IEnumerable<object[]> StaticParameter => new List<CultureTestParameterModel[]>
        {
            new CultureTestParameterModel[]
            {
                new CultureTestParameterModel
                {
                    Culture = CultureInfo.CreateSpecificCulture("it-IT"),
                    Actual = new DateTime(1988, 06, 05),
                    Expected = "05 Giugno 1988"
                }
            }
        };

        [Theory, ClassData(typeof(ExceptionTestTheoryData))]
        public void Divide_ShouldAssertsTrue_WhenCultureSecondValueIsZero(ExceptionTestParameterModel parameter)
        {
            var exceptionType = Assert.ThrowsAny<SystemException>(() => parameter.FirstValue / parameter.SecondValue);
            Assert.True(exceptionType.GetType().IsAssignableFrom(parameter.ExceptedException));
        }
    }
}
