using SE_DotnetCore1819;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibr 
{
    public class BetterCalculator:Calculation
    {
        public int Mul(int a, int b)
        {
            return a * b;
        }
        public int sub(int a, int b)
        {
            return a - b;
        }
        public int div(int a, int b)
        {
            return a / b;
        }
    }
}
