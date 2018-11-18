using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsole.Sample3_5
{
    public class Tasklet
    {
        public void Run()
        {
            Case4.Caller.Run();

            Console.ReadKey();
        }
    }
}
