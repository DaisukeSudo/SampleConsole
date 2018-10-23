using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using static SampleConsole.Sample3.Case1.Function2;
using static SampleConsole.Sample3.Case1.VectorUtil;

namespace SampleConsole.Sample3.Case1
{
    public class Caller
    {
        public static void Run()
        {
            Console.WriteLine("Case1 \n");

            Console.WriteLine("> Double(12)");
            Console.WriteLine(Double(12));
            Console.WriteLine();

            var v1 = new Vector2(10, 15);
            var v2 = new Vector2(25, 35);
            Console.WriteLine("> v1");
            Console.WriteLine(v1);
            Console.WriteLine();
            Console.WriteLine("> v2");
            Console.WriteLine(v2);
            Console.WriteLine();
            Console.WriteLine("> Distance(v1, v2)");
            Console.WriteLine(Distance(v1, v2));
            Console.WriteLine();
        }
    }
}
