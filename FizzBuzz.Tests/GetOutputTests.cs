using System;
using System.Collections.Generic;
using FizzBuzz.App;
using Xunit;

namespace FizzBuzz.Tests
{
    public class GetOutputTests
    {
        [Fact]
        public void WhenICallGetANotImplementedExceptionIsThrown()
        {
            // Arrange
            IGetOutput subject = new GetOutput();

            // Act
            // Assert
            Assert.Throws<NotImplementedException>(() => subject.Get(1));
        }

        [Fact]
        public void NumbersFrom1To100ThatAreFizzOnly()
        {
            // Arrange
            IGetOutput subject = new GetOutput();

            var listOfFizzOnly = new List<int>() {3, 6, 9, 12, 18, 21, 24, 27, 33, 36, 39, 42, 48, 51, 54, 57, 63, 66, 69, 72, 78, 81, 84, 87, 93, 96, 99 };
            // Act
            // Assert
            Assert.All(listOfFizzOnly, x => Assert.Equal("Fizz", subject.Get(x)));
        }

        [Fact]
        public void NumbersFrom1To100ThatAreBuzzOnly()
        {
            // Arrange
            IGetOutput subject = new GetOutput();

            var listOfBuzzOnly = new List<int>() { 5, 10, 20, 25, 35, 40, 50, 55, 65, 70, 80, 85, 100 };
            // Act
            // Assert
            Assert.All(listOfBuzzOnly, x => Assert.Equal("Buzz", subject.Get(x)));
        }

        [Fact]
        public void NumbersFrom1To100ThatAreFizzBuzz()
        {
            // Arrange
            IGetOutput subject = new GetOutput();

            var listOfFizzBuzz = new List<int>() {15, 30, 45, 60, 75, 90 };
            // Act
            // Assert
            Assert.All(listOfFizzBuzz, x => Assert.Equal("FizzBuzz", subject.Get(x)));
        }

        [Fact]
        public void NumbersFrom1To100ThatAreNotFizzOrBuzzOrFizzBuzz()
        {
            // Arrange
            IGetOutput subject = new GetOutput();

            var listOfNumbers = new List<int>()
            {
                1, 2, 4, 7, 8, 11, 13, 14, 16, 17, 19, 21, 22, 23, 26, 28, 29, 31, 32, 34, 36, 37, 38, 39, 41, 43, 44, 46, 47, 49, 52, 53,
                56, 58, 59, 61, 62, 64, 66, 67, 68, 71, 73, 74, 76, 77, 79, 82, 83, 86, 88, 89, 91, 92, 94, 97, 98
            };
            // Act
            // Assert
            Assert.All(listOfNumbers, x => Assert.Equal(x.ToString(), subject.Get(x)));
        }

    }
}