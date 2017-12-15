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

        [Theory]
        [InlineData("0", 0)]
        [InlineData("1", 1)]
        [InlineData("2", 2)]
        [InlineData("3", 3)]
        public void Should_return_a_number_if_only_one_parameter(string input, int expected)
        {
            //When
            var result = _stringCalculator.Add(input);
            //Then
            Assert.Equal(result, expected);
        }


        [Theory]
        [InlineData("0,3,2", 5)]
        [InlineData("1,1,2", 4)]
        public void Should_return_a_sum_of_numbers_if_more_than_one_parameter(string input, int expected)
        {
            //When
            var result = _stringCalculator.Add(input);
            //Then
            Assert.Equal(result, expected);
        }

    }
}
