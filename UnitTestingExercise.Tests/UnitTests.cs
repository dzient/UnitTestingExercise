using System;
using Xunit;
//-----------------------------------------------------------------
// UnitTesting Exercise
//
// Name: David Zientara
// Date: 7-26-2022
// Comments: An exercise in using unit testing
// Made changes per the instructions
//-----------------------------------------------------------------
//class Calculator { }
namespace UnitTestingExercise.Tests
{
    
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(1, 1, 1, 3)]
        [InlineData(1, 3, 5, 9)]
        [InlineData(11, 13, 17, 41)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            //UnitTests UT = new UnitTests();
            //UT.AddTest
            Calculator Calc = new Calculator();
            //int actual = 0;
            var actual = Calc.Add(num1, num2, num3);
           
            //var actual = UT.AddTest(num1, num2, num3, expected);
            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual

            //Assert
            Assert.Equal(expected, actual);

            //Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4,2,2)]//Add test data <-------
        [InlineData(1, 2, -1)]
        [InlineData(10, 7, 3)]
        [InlineData(7, 10, -3)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator Calc = new Calculator();

            var actual = Calc.Subtract(minuend, subtrhend);
            //Act

            //Assert
            Assert.Equal(expected,actual);
        }

        [Theory]
        [InlineData(3,3,9)]//Add test data <-------
        [InlineData(7, 5, 35)]
        [InlineData(11, 12, 132)]
        [InlineData(5, 12,60)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            Calculator Calc = new Calculator();

            var actual = Calc.Multiply(num1, num2);

            //Act

            //Assert
            Assert.Equal((int)expected, actual);

        }

        [Theory]
        [InlineData(8,2,4)]//Add test data <-------
        [InlineData(5, 2, 2)]
        [InlineData(17, 5, 3)]
        [InlineData(100, 2, 50)]
        [InlineData(1000, 100, 10)]
        [InlineData(10000, 6, 1666)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator Calc = new Calculator();


            //Act
            var actual = Calc.Divide(num1,num2);

            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
