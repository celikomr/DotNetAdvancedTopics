using System;
using System.Globalization;

namespace xUnitTesting.Models
{
    public class CultureTestParameterModel
    {
        public CultureInfo Culture { get; set; }
        public DateTime Actual { get; set; }
        public string Expected { get; set; }
    }
}