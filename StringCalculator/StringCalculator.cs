using System;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public StringCalculator()
        {

        }

        public int Add(string stringNumbers)
        {
            if (String.IsNullOrWhiteSpace(stringNumbers)) return 0;
            throw new NotImplementedException("create tests for other scenarios");
        }
    }
}
