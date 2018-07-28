using System;

namespace StringCalculatorKata
{
    public class StringCalculator
    {

        public int Add(string stringNumbers)
        {
            //default delimiter
            string delimeter = ",";

            //custom delimiter
            if (stringNumbers.StartsWith("//"))
            {
                stringNumbers = stringNumbers.Substring(2);
                delimeter = GetDelimiterFromStringInput(stringNumbers);
            }


            //replace new lines with delimeter
            stringNumbers = stringNumbers.Replace("\n", delimeter);

            //construct array of numbers
            var numbers = stringNumbers.Split(delimeter.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            var sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int number;
                if (Int32.TryParse(numbers[i], out number))
                {
                    if (number < 0)
                    {
                        throw new NegativeNumberException($"{number} is a negatif number");
                    }
                    sum += number;
                }
            }
            return sum;
        }

        private string GetDelimiterFromStringInput(String stringNumbers)
        {
            return stringNumbers.Split('\n')[0];
        }
    }
}
