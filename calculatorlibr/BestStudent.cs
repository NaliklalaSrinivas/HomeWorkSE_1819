using SE_DotnetCore1819;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorLibr
{
    public class BestStudent
    {
        public int LocalSum()
        {
            Calculation calci = new Calculation();
            var total = calci.Add(100,200);

            Console.WriteLine("Adding Break point");
            return total;
        }

        public void BlaBla()
        {
            Console.WriteLine("Best Student Vasu SE bla Bla bla bla bla");
        }
    }
}
