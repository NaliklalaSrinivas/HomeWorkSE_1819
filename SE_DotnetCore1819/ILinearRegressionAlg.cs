using System;
using System.Collections.Generic;
using System.Text;

namespace SE_DotnetCore1819
{
    interface ILinearRegressionAlg
    {
        object GetResult();

        void Train(int[] data);

        void Save();
        void Load();
    }
}
        