using FibonacciClassLibrary;
using System;
using Xunit;


namespace MyClassLibrary.Tests {
    public class FibonacciCalculatorTest {
        private static FibonacciCalculator CreateDefaultSUT() {

            //sut = system under test
            var sut = new FibonacciCalculator();
            return sut;
        }
        
        [Theory] //Values with parameters //A second way is with inline data
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(30, 832040)]
        [InlineData(-1, 83)]
        [InlineData(91, 4660046610375530309)]


        public void FibonacciSeries_ValidInput_ExpectedException(long n, long expected) {

            // Arrange
             var sut = CreateDefaultSUT();

            //Act
            var actual = sut.FibonacciSeries(n);

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void FibonacciSeries_NegativeInputeValue_ExpectedException() {

            //Arrange
            var sut = CreateDefaultSUT();
            long n = -1;

            //Act + Assert
            Assert.Throws<ArgumentException>(() => {
                var actual = sut.FibonacciSeries(n);
            });

        }
        [Fact]
        public void FibonacciSeries_BigNumberInputValue_ExpectedException() {

            //Arrange
            var sut = CreateDefaultSUT();
            long n = 91;

            //Act + Assert
            Assert.Throws<ArgumentException>(() => {
                var actual = sut.FibonacciSeries(n);
            });

        }

    }
}
