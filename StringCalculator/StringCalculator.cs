﻿using System;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public StringCalculator()
        {

        }

        public int Add(string stringNumbers)
        {
            var delimeter = ',';
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
    }
}
