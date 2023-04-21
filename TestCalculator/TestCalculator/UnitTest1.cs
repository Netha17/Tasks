using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CalculatorLibrary;

namespace TestCalculator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Divide_PositiveNumbers_ReturnsPositiveQuotient()
        {
            //Arrange
            int expected = 5;
            int numerator = 30;
            int denominator = 6;

            //Act
            int actual=BasicOperations.Divide(numerator, denominator);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Divide_NegativeNumbers_ReturnsPositiveQuotient()
        {
            //Arrange
            int expected = 5;
            int numerator = -30;
            int denominator = -6;

            //Act
            int actual = BasicOperations.Divide(numerator, denominator);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Divide_NegativeDenominator_ReturnsNegativeQuotient()
        {
            //Arrange
            int expected = -5;
            int numerator = 30;
            int denominator = -6;

            //Act
            int actual = BasicOperations.Divide(numerator, denominator);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Divide_NegativeNumerator_ReturnsNegativeQuotient()
        {
            //Arrange
            int expected = -5;
            int numerator = -30;
            int denominator = 6;

            //Act
            int actual = BasicOperations.Divide(numerator, denominator);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Add_PositiveNumbers_ReturnPositiveResult()
        {
            BasicOperations b=new BasicOperations();
            PrivateObject p=new PrivateObject(b);
            object[] o = { 2, 3 };
            int actual=(int)p.Invoke("add",o);
            Assert.AreEqual(5, actual);


        }
    }
}
