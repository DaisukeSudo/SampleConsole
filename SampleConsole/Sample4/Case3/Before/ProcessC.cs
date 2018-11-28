using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsole.Sample4.Case3.Before
{
    public class ProcessC
    {
        public void Execute() =>
            Console.WriteLine($"FunctionC(10) = {CommonUtility.FunctionC(10)}");
    }
}
