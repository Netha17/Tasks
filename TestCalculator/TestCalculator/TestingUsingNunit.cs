using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rhino.Mocks;
using CalculatorLibrary;
using Moq;

namespace TestCalculator
{
    [TestFixture]
    
    internal class TestingUsingNunit
    {
        [Test]
        [TestCase(30,5,6)]
        [TestCase(30,-5,-6)]
        public void Divide_PositiveNumbers_ReturnPositiveNumber(int a,int b,int expected )
        {
            
            int actual = BasicOperations.Divide(a,b);
            Assert.AreEqual(expected, actual);
        }
        //testcase using moq framework
        [Test]
        public void CheckValues_Digits_ReturnsTrue()
        {
            Mock<BasicOperations> m = new Mock<BasicOperations>();
            m.Setup(x => x.CheckDigitsOnly()).Returns(true);
            Assert.AreEqual (true, m.Object.CheckDigitsOnly());
        }
        //testcase using rhinomock framework
        [Test]
        public void CheckValues_Digits_ReturnsTrueUsingRhinoMocks()
        {
            var r = Rhino.Mocks.MockRepository.GenerateMock<BasicOperations>();
            r.Expect(x => x.CheckDigitsOnly()).Return(true);
            BasicOperations b= new BasicOperations();
            Assert.AreEqual(true, r.CheckDigitsOnly());
        }
    }
}
