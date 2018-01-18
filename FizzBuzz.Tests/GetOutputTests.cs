using System;
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
    }
}