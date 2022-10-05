using xUnitTesting.Models;

namespace xUnitTesting.Theories
{
    public class ExceptionTestTheoryData : TheoryData<ExceptionTestParameterModel>
    {
        public ExceptionTestTheoryData()
        {
            Add(new ExceptionTestParameterModel
            {
                FirstValue = 15,
                SecondValue = 0,
                ExceptedException = typeof(DivideByZeroException)
            });
        }
    }
}
