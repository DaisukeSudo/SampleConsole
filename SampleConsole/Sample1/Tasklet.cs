﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsole.Sample1
{
    public class Tasklet
    {
        public void Run()
        {
            Case1.Caller.Run();

            Case3.Caller.Run();

            Case4.Caller.Run();

            Console.ReadKey();
        }
    }
}
