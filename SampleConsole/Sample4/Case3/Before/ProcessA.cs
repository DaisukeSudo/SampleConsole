using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsole.Sample4.Case3.Before
{
    public class ProcessA
    {
        public void Execute() =>
            Console.WriteLine($"FunctionA(10) = {CommonUtility.FunctionA(10)}");
    }
}
