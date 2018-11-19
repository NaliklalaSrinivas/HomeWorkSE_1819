using System;
using System.Collections.Generic;
using System.Text;

namespace SE_DotnetCore1819
{
    class ConcreteALgorithm:ILinearRegressionAlg
    {
        int m_Result = 0;
        Result res = new Result();



        public object GetResult()
        {
            return this.m_Result;
        }

        public double load()
        {
            throw new NotImplementedException();
        }

        public double Save()
        {
            throw new NotImplementedException();
        }

        public void Train(int[] data)
        {
            double sum = 1;

            foreach (var item in data)
            {
                sum += item;
            }
            if (sum < 100)
            {
                Console.WriteLine("Output cause the sum vale is Less than 100");
            this.m_Result = 0;
            }
            else
                {
                    Console.WriteLine("Output cause the sum vale is Greather than 100");
            this.m_Result = 1;
            }
        }

        void ILinearRegressionAlg.Load()
        {
            throw new NotImplementedException();
        }

        void ILinearRegressionAlg.Save()
        {
            throw new NotImplementedException();
        }
    }
}
