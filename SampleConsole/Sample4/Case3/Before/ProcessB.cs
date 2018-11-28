using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsole.Sample4.Case3.Before
{
    public class ProcessB
    {
        public void Execute() =>
            Console.WriteLine($"FunctionB(10) = {CommonUtility.FunctionB(10)}");
    }
}
