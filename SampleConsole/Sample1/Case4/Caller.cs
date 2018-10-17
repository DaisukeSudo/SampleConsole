using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SampleConsole.Sample1.Case4
{
    public class Caller
    {
        public static void Run()
        {
            Console.WriteLine("Case4");

            Task.WaitAll(
                Task.Run(() => new ProcessA().Run()),
                Task.Run(() => new ProcessB().Run())
                );
        }
    }
}
