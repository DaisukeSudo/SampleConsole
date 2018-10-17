using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SampleConsole.Sample1.Case3
{
    public class Caller
    {
        public static void Run()
        {
            Console.WriteLine("Case3");
            Console.WriteLine("(Count asynchronously)");

            var counter = new Counter();

            int func()
            {
                var value = counter.GetValue();
                Console.WriteLine(value);
                Thread.Sleep(10);
                return value;
            }

            Enumerable
                .Range(0, 10)
                .AsParallel()
                .Select(x => func())
                .ToList();

            Console.WriteLine();
        }
    }
}
