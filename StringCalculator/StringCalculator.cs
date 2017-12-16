using System;

namespace StringCalculatorKata
{
    public class StringCalculator
    {

        public int Add(string stringNumbers)
        {
            var delimeter = ',';
            if (stringNumbers.StartsWith("//"))
            {
                stringNumbers = stringNumbers.Substring(2);
                delimeter = GetDelimiterFromStringInput(stringNumbers);
            }


            //replace new lines with delimeter
            stringNumbers = stringNumbers.Replace('\n', delimeter);

            //construct array of numbers
            var numbers = stringNumbers.Split(delimeter);

            var sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int number;
                if (Int32.TryParse(numbers[i], out number))
                {
                    sum += number;
                }
            }
            return sum;
        }

        private char GetDelimiterFromStringInput(string stringNumbers)
        {
            return stringNumbers.Split('\n')[0].ToCharArray()[0];
        }
    }
}
