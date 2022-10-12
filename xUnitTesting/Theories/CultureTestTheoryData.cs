using System.Globalization;
using xUnitTesting.Models;

namespace xUnitTesting.Theories
{
    public class CultureTestTheoryData : TheoryData<CultureTestParameterModel>
    {
        public CultureTestTheoryData()
        {
            Add(new CultureTestParameterModel
            {
                Culture = CultureInfo.CreateSpecificCulture("tr-TR"),
                Actual = new DateTime(2017, 05, 15),
                Expected = "15 Mayıs 2017"
            });

            Add(new CultureTestParameterModel
            {
                Culture = CultureInfo.CreateSpecificCulture("en-US"),
                Actual = new DateTime(1987, 08, 13),
                Expected = "13 August 1987"
            });
        }
    }
}
