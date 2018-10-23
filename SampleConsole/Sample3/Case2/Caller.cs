using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using static SampleConsole.Sample3.Case2.VectorUtil;

namespace SampleConsole.Sample3.Case2
{
    public class Caller
    {
        public static void Run()
        {
            Console.WriteLine("Case2 \n");

            var v1 = new Vector2(10, 20);
            var v2 = new Vector2(15, 32);
            Console.WriteLine("> var v1 = new Vector2(10, 20)");
            Console.WriteLine("> var v2 = new Vector2(15, 32)");
            Console.WriteLine("> Distance(v1, v2)");
            Console.WriteLine(Distance(v1, v2));
            Console.WriteLine();

            var p1 = new Pin(1, "Location A", 10, 20);
            var p2 = new Pin(2, "Location B", 15, 32);
            Console.WriteLine("> var p1 = new Pin(1, \"Location A\", 10, 20)");
            Console.WriteLine("> var p2 = new Pin(2, \"Location B\", 15, 35)");
            Console.WriteLine("> Distance(p1, p2)");
            Console.WriteLine(Distance(p1, p2));
            Console.WriteLine();
        }
    }
}
