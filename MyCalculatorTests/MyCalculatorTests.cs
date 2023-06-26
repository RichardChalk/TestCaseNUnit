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
    }
}
