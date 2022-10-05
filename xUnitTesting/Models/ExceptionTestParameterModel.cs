using System;

namespace xUnitTesting.Models
{
    public class ExceptionTestParameterModel
    {
        public int? FirstValue { get; set; }
        public int? SecondValue { get; set; }
        public Type ExceptedException { get; set; }
    }
}