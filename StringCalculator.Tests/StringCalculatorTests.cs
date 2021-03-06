using StringCalculatorKata;
using System;
using Xunit;

namespace StringCalculatorTests
{
    public class StringCalculatorTests
    {
        public StringCalculatorTests() { }
        private StringCalculator _stringCalculator = new StringCalculator();

        [Theory]
        [InlineData("")]
        public void Empty_string_should_return_0(String input)
        {
            //When
            int result = _stringCalculator.Add(input);

            //Then
            Assert.Equal(0, result);
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

        [Theory]
        [InlineData("1\n2\n3", 6)]
        [InlineData("1\n2,3", 6)]
        [InlineData("\n1\n2,3", 6)]
        public void Should_also_handle_new_line(string input, int expected)
        {
            //When
            var result = _stringCalculator.Add(input);
            //Then
            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData("//;\n1;2", 3)]
        [InlineData("//**\n1**2**3", 6)]
        public void Should_handle_another_delimiter(string input, int expected)
        {
            var result = _stringCalculator.Add(input);
            //Then
            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData("//;\n-1;2", "negatives not allowed: -1")]
        [InlineData("//;\n-1;-2", "negatives not allowed: -1 -2")]
        [InlineData("//**\n-1**2**-3", "negatives not allowed: -1 -3")]
        public void should_throw_exception_for_negatif_numbers(string input, string errorMessage)
        {
            Exception ex = Assert.Throws<NegativeNumberException>(() => _stringCalculator.Add(input));
            Assert.Equal(errorMessage, ex.Message);
        }


        [Theory]
        [InlineData("//;\n1000;2", 2)]
        [InlineData("//**\n1004**232**3", 235)]
        public void Should_ignore_numbers_higher_than_1000(string input, int expected)
        {
            var result = _stringCalculator.Add(input);
            //Then
            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData("//[;]\n1;2", 3)]
        [InlineData("//[***]\n1***2***3", 6)]
        public void Should_handle_another_delimiter_with_brackets(string input, int expected)
        {
            var result = _stringCalculator.Add(input);
            //Then
            Assert.Equal(result, expected);
        }

        [Theory]
        [InlineData("//[*][%]\n1*2%3**%**8", 14)]
        public void Should_allow_multiple_delimiters_with_brackets(string input, int expected)
        {
            var result = _stringCalculator.Add(input);
            //Then
            Assert.Equal(expected,result);
        }


    }
}
