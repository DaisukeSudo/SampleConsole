using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsole.Sample2
{
    public class Tasklet
    {
        public void Run()
        {
            Case1.Caller.Run();

            Console.ReadKey();
        }
    }
}
