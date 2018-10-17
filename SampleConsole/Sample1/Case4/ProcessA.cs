using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SampleConsole.Sample1.Case4
{
    public class ProcessA
    {
        public void Run()
        {
            int func(int x)
            {
                StatusManager.Status = (Status)((x % 3) + 1);
                Console.WriteLine($"I'm A. Status is {StatusManager.Status}");
                Thread.Sleep(20);
                return x;
            }

            Enumerable
                .Range(0, 5)
                .AsParallel()
                .Select(func)
                .ToList();
        }
    }
}
