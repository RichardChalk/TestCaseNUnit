using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCaseNUnit;

namespace TestCaseNUnitTests
{
    [TestFixture]
    public class MyCalculatorTests
    {
        private MyCalculator _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new MyCalculator();
        }

        [TestCase(2, 3, ExpectedResult = 5)]
        [TestCase(-2, 3, ExpectedResult = 1)]
        [TestCase(0, 0, ExpectedResult = 0)]
        public int Add_Test(int a, int b)
        {
            return _sut.Add(a, b);
        }

        [TestCase(2, 3, ExpectedResult = -1)]
        [TestCase(-2, 3, ExpectedResult = -5)]
        [TestCase(0, 0, ExpectedResult = 0)]
        public int Subtract_Test(int a, int b)
        {
            return _sut.Subtract(a, b);
        }

        [TestCase(2, 3, 4, ExpectedResult = 24)]
        [TestCase(-2, 3, 7, ExpectedResult = -42)]
        [TestCase(0, 0, 0, ExpectedResult = 0)]
        public int Multiply_Test(int a, int b, int c)
        {
            return _sut.Multiply (a, b, c);
        }

        [TestCase(5.5, 2, ExpectedResult = 2.75)]
        [TestCase(10, 2.5, ExpectedResult = 4)]
        [TestCase(3, 2, ExpectedResult = 1.5)]
        public decimal Divide_Test(decimal a, decimal b)
        {
            return _sut.Divide(a, b);
        }

        [TestCase(18, 7, ExpectedResult = 4)]
        [TestCase(10, 2, ExpectedResult = 0)]
        [TestCase(3, 2, ExpectedResult = 1)]
        public int Modulo_Test(int a, int b)
        {
            return _sut.Modulo(a, b);
        }
    }
}
