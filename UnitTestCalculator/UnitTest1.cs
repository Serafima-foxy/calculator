using System;
using NUnit.Framework;
using Calculator;

namespace UnitTestCalculator
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase(1, 3, 4)]
        [TestCase(-2, -3, -5)]
        public void TestSumMethod(int numb1, int numb2, int expRes)
        {
            double act = new Calculations().Sum(numb1, numb2);
            Assert.AreEqual(expRes, act);
        }

        [TestCase(5, 2.0, 3.0)]
        [TestCase(0, -2, 2)]
        [TestCase(-3.5, -3.5, 0.0)]
        [TestCase(-5, 5.5, -10.5)]
        public void TestSubstractionMethod(double number1, double number2, double expRes)
        {
            double actRes = new Calculations().Diff(number1, number2);
            Assert.AreEqual(expRes, actRes);
        }

        [TestCase(9, 3, 3)]
        [TestCase(0, 3, 0)]
        [TestCase(-12, -3, 4)]
        [TestCase(7.0, 1, 7.0)]
        public void TestDivMethod(double numb1, double numb2, double expRes)
        {
            double actRes = new Calculations().Division(numb1, numb2);
            Assert.AreEqual(expRes, actRes);
        }
        
        [TestCase(2, "∞")]
        [TestCase(-24, "-∞")]
        public void TestDivByZeroMethod(int numb1, string expRes)
        {
            double actRes = new Calculations().Division(numb1, 0);
            Assert.AreEqual(expRes, actRes.ToString());
        }

        [TestCase(10, 0, 0)]
        [TestCase(-10.0, 2, -20.0)]
        [TestCase(-10, -2.5, 25.0)]
        public void TestMultiplyMethod(double number1, double number2, double expRes)
        {
            double actRes = new Calculations().Multiply(number1, number2);
            Assert.AreEqual(expRes, actRes);
        }

        [TestCase(10.0, 3, 1.0)]
        [TestCase(-10, 4, -2)]
        [TestCase(-0, -4, 0)]
        [TestCase(8.0, -3.0, 2.0)]
        public void TestRemainderOfDevision(double number1, double number2, double expRes)
        {
            double actRes = new Calculations().RemainderOfDivision(number1, number2);
            Assert.AreEqual(expRes, actRes);
        }
    }
}