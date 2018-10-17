using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SampleConsole.Sample1.Case4
{
    public class ProcessB
    {
        public void Run()
        {
            int func(int x)
            {
                Console.WriteLine($"I'm B. Status is {StatusManager.Status}");
                Thread.Sleep(10);
                return x;
            }

            Enumerable
                .Range(0, 10)
                .AsParallel()
                .Select(func)
                .ToList();
        }
    }
}
