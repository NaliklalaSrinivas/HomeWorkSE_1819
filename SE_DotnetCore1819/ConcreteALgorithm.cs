using System;
using System.Collections.Generic;
using System.Text;

namespace SE_DotnetCore1819
{
    class ConcreteALgorithm:ILinearRegressionAlg
    {
        int m_Result = 0;

        public int Save { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int load { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public object GetResult()
        {
            return this.m_Result;
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
    }
}
