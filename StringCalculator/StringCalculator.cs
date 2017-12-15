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
            var delimeter = ',';
            var numbers = stringNumbers.Split(delimeter);
            var sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += Int32.Parse(numbers[i]);
            }
            return sum;
        }
    }
}
