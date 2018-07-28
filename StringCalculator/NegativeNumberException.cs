using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace StringCalculatorKata
{

    public class NegativeNumberException : Exception
    {
        public NegativeNumberException(List<int> numbers) : base(generateMessage(numbers))
        {
        }

        private  static string generateMessage(List<int> numbers)
        {
            return "negatives not allowed: " + String.Join(" ", numbers.Select(x => x));
        }

        public NegativeNumberException(string message) : base(message)
        {

        }
    }
}