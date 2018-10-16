using System;

namespace SampleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample1.Function1.Run();

            Sample1.Caller.Run();

            Console.ReadKey();
        }
    }
}
