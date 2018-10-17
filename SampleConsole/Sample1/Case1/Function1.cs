using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsole.Sample1.Case1
{
    public class Function1
    {
        public static void Run()
        {
            Console.WriteLine("Function1.Run \n");

            Console.WriteLine("Inc(4)");
            Console.WriteLine($"> {Inc(4)} \n");

            Console.WriteLine("Add(4, 5)");
            Console.WriteLine($"> {Add(4, 5)} \n");
        }


        public static int Inc(int x) => x + 1;

        public static int Add(int x, int y) => x + y;
    }
}
