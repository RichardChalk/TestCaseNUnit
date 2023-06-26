using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCaseNUnit
{
    public class MyCalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b, int c)

        {
            return a * b * c;
        }

        public decimal Divide(decimal a, decimal b)
        {
            return a / b;
        }

        public int Modulo(int a, int b)
        {
            return a % b;
        }
    }
}
