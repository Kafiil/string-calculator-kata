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
            return (String.IsNullOrWhiteSpace(stringNumbers)) ? 0 : Int32.Parse(stringNumbers);
        }
    }
}
