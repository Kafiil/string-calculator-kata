using StringCalculatorKata;
using System;
using Xunit;

namespace StringCalculatorTests
{
    public class StringCalculatorTests
    {

        public StringCalculatorTests() { }
        private StringCalculator _stringCalculator = new StringCalculator();

        [Fact]
        public void Empty_string_should_return_0()
        {
            //Given
            var stringNumbers = "";
            //When
            int result = _stringCalculator.Add(stringNumbers);

            //Then
            Assert.Equal(result, 0);
        }

    }
}
