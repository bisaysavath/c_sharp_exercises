using System;
using System.Linq;
using Exercise02;
using Xunit;

namespace Exercise02UnitTests
{
    public class Exercise02UnitTests
    {
        [Fact]
        public void TestNumber4()
        {
            // arrange
            int number = 4;
            string expected = $"Prime factors of {number} are:2x2";

            // act
            string actual = Exercise02.Program.PrimeFactors(number);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestNumber7()
        {
            // arrange
            int number = 7;
            string expected = $"Prime factors of {number} are:7";

            // act
            string actual = Exercise02.Program.PrimeFactors(number);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestNumber30()
        {
            // arrange
            int number = 30;
            string expected = $"Prime factors of {number} are:2x3x5";

            // act
            string actual = Exercise02.Program.PrimeFactors(number);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestNumber40()
        {
            // arrange
            int number = 40;
            string expected = $"Prime factors of {number} are:2x2x2x5";

            // act
            string actual = Exercise02.Program.PrimeFactors(number);

            // assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestNumber50()
        {
            // arrange
            int number = 50;
            string expected = $"Prime factors of {number} are:2x5x5";

            // act
            string actual = Exercise02.Program.PrimeFactors(number);

            // assert
            Assert.Equal(expected, actual);
        }
    }
}
