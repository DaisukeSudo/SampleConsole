using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SampleConsole.Sample3_5.Case4
{
    public class Caller
    {
        public static void Run()
        {
            Console.WriteLine("Case4 \n");

            new Client(new Container()).MainProcess();
        }
    }
}
