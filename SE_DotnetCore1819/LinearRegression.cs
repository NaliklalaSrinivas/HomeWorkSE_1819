using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SE_DotnetCore1819
{
    class LinearRegression : ILinearRegressionAlg
    {
        int m_Result = 0;
        int sum = 0;
        int count = 0;
        int SumOfSquares = 0;
        double resultAvrg = 0;
        double resultmedian = 0;
        double Mediantotal = 0;
        double Averagetotal = 0;
        double Variencestotal = 0;

        Result result_ = new Result();

        public object GetResult()
        {
            String finalresult = "Average value :" +result_.AvgResult +"Median Value :" +result_.MedianResult +"Variences Value :" +result_.VariencesResult;
            return finalresult;
        }

        public void Train(int[] data)
        {
            int sum_ = 1;

            foreach (var item in data)
            {
                sum_ *= item;
            }

            this.m_Result = sum_;
        }
        public void Cal(int[] data) {
            foreach (var item in data)
            {
                sum += item;
                count += count + 1;
                SumOfSquares += sum * sum;
            }
        }
        /*public void mean() {
            var meanvalue = sum / count;

            Console.WriteLine("Output Mean : "+meanvalue);
        }*/
        public void Median(int[] nums)
        {
            var medianvalue = getAverage(nums) / 2;
            Console.WriteLine("Output Mean : " + medianvalue);
            Mediantotal = +medianvalue;
            result_.MedianResult = Mediantotal;
        }
        public double variance(int[] nums)
        {
            if (nums.Length > 1)
            {

                // Get the average of the values
                double avg = getAverage(nums);

                // Now figure out how far each point is from the mean
                // So we subtract from the number the average
                // Then raise it to the power of 2
                double sumOfSquares = 0.0;

                foreach (int num in nums)
                {
                    sumOfSquares += Math.Pow((num - avg), 2.0);
                }
                Variencestotal = sumOfSquares / (double)(nums.Length - 1);
                Console.WriteLine("Output Variance : " + Variencestotal);
                result_.VariencesResult = Variencestotal;
                // Finally divide it by n - 1 (for standard deviation variance)
                // Or use length without subtracting one ( for population standard deviation variance)
                return result_.VariencesResult;
            }
            else { return 0.0; }
        }

        // Square root the variance to get the standard deviation
        public double standardDeviation(double variance)
        {
            return Math.Sqrt(variance);
        }

        // Get the average of our values in the array
        public double getAverage(int[] nums)
        {
            int sum = 0;

            if (nums.Length > 1)
            {

                // Sum up the values
                foreach (int num in nums)
                {
                    sum += num;
                }
                Averagetotal = sum / (double)nums.Length;
                // Divide by the number of values
                Console.WriteLine("Output Average : " + Averagetotal);
                result_.AvgResult = Averagetotal;
                return result_.AvgResult;

            }
            else { return (double)nums[0]; }
        }


        public void Save()
        {
            String str = "{\"Average\": " + result_.AvgResult  + ",\"Median\": " + result_.MedianResult + ",\"Variences\": " + result_.VariencesResult + "}";

            File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "VasuCalculationsSaved.json"), str);
           
        }

           public  void Load()
        {
            var builder = new ConfigurationBuilder()

           .AddJsonFile("VasuCalculationsSaved.json", optional: false, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            result_.AvgResult = double.Parse(configuration["Average"]);
            result_.MedianResult = double.Parse(configuration["Median"]);
            result_.VariencesResult = double.Parse(configuration["Variences"]);

        }
    }
}
