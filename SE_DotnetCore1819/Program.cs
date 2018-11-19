using CalculatorLibr;
using System;
using Microsoft.Extensions.Configuration;
using System;
using System.Globalization;
using System.IO;


namespace SE_DotnetCore1819
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

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

            var builder = new ConfigurationBuilder()

          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("C:\\Users\\Vasu_\\source\\repos\\HomeWorkSE_1819\\SE_DotnetCore1819\\appsettings.json", optional: false, reloadOnChange: true)
          .AddEnvironmentVariables();


            IConfigurationRoot configuration = builder.Build();

            //
            // From root of appsettings.json
            var setting1 = configuration["Setting1"];
            Console.WriteLine(setting1);
            var setting2 = configuration["Setting2"];
            Console.WriteLine(setting2);
            var setting3 = configuration["Setting3"];
            Console.WriteLine(setting3);

            Console.WriteLine("Hello Interfaces!");

            int[] data = new int[] { 1, 3, 5, 7, 300};

            ILinearRegressionAlg alg = new ConcreteALgorithm();

            alg.Train(data);

            var result = alg.GetResult();            

            Console.WriteLine($"{alg.GetType().Name} result: {result}");

            LinearRegression algo = new LinearRegression();
            alg.Train(data);

            var result1 = alg.GetResult();
            algo.Load();
            Console.WriteLine("previous result:" + algo.GetResult());
            algo.getAverage(data);
            algo.Median(data);
            algo.variance(data);
            
            Console.WriteLine("current result:" + algo.GetResult());
            algo.Save();
           

            Console.ReadKey();

        }
    }
}
