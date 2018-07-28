using System;
using System.Linq;
using System.Collections.Generic;

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

            List<int> negatifs = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                int number;
                if (Int32.TryParse(numbers[i], out number))
                {
                    if (number < 0)
                    {
                        negatifs.Add(number);
                    }

                    if (number < 1000) sum += number;
                }
            }
            if (negatifs.Count > 0) throw new NegativeNumberException(negatifs);
            return sum;
        }

        private string GetDelimiterFromStringInput(String stringNumbers)
        {
            return stringNumbers.Split('\n')[0];
        }
    }
}
