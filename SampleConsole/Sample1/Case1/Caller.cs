using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using static SampleConsole.Sample1.Case1.Function1;

namespace SampleConsole.Sample1.Case1
{
    public class Caller
    {
        public static void Run()
        {
            Console.WriteLine("Case1 \n");

            Console.WriteLine("> Inc(4)");
            Console.WriteLine(Inc(4));
            Console.WriteLine();

            Console.WriteLine("> Add(4, 5)");
            Console.WriteLine(Add(4, 5));
            Console.WriteLine();
        }
    }
}
