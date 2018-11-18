using System;
using System.Collections.Generic;
using System.Text;

namespace SE_DotnetCore1819
{
    class LinearRegression:ILinearRegressionAlg
    {
        int m_Result = 0;
        int sum = 0;
        int count = 0;
        int SumOfSquares = 0;

        public object GetResult()
        {
            return this.m_Result;
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
            var medianvalue = getAverage(nums)/2;
            Console.WriteLine("Output Mean : " + medianvalue);
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
                Console.WriteLine("Output Variance : " + sumOfSquares / (double)(nums.Length - 1));
                // Finally divide it by n - 1 (for standard deviation variance)
                // Or use length without subtracting one ( for population standard deviation variance)
                return sumOfSquares / (double)(nums.Length - 1);
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

                // Divide by the number of values
                Console.WriteLine("Output Average : " + sum / (double)nums.Length);
                return sum / (double)nums.Length;
                
            }
            else { return (double)nums[0]; }
        }
        public int Save { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int load { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    }
}
