using CalculatorLibr;
using System;

namespace SE_DotnetCore1819
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!");

            BetterCalculator cal = new BetterCalculator();
            var add = cal.Add(10, 20);
            Console.WriteLine(add);
            var sub = cal.sub(10,20);
            Console.WriteLine(sub);
            var mul = cal.Add(10, 20);
            Console.WriteLine(mul);
            var div = cal.sub(10, 20);
            Console.WriteLine(div);
            BestStudent bcal = new BestStudent();
            int localSum = bcal.LocalSum();
            bcal.BlaBla();
            Console.ReadKey();

        }
    }
}
