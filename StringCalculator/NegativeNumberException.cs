using System;
using System.Runtime.Serialization;

namespace StringCalculatorKata
{
   
    public class NegativeNumberException : Exception
    {
        public NegativeNumberException()
        {
        }

        public NegativeNumberException(string message) : base(message)
        {
        }
    }
}