using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsole.Sample4.Case3.Before
{
    public static class CommonUtility
    {
        public static int FunctionA(int x) => x + x;

        public static int FunctionB(int x) => FunctionA(x);

        public static int FunctionC(int x) => FunctionB(x);
    }
}
