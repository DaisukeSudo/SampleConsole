using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using static SampleConsole.Sample2.Case1.ListUtil;

namespace SampleConsole.Sample2.Case1
{
    public class Caller
    {
        public static void Run()
        {
            Console.WriteLine("Case1 \n");

            var list1 = new int[] { 0, 1, 2, 3, 4, 5, 6 };
            var list2 = new int[] { 1, 3, 5 };
            Console.WriteLine($"list1 = {list1.ToJson()}");
            Console.WriteLine($"list2 = {list2.ToJson()}");
            Console.WriteLine();

            Console.WriteLine("Ignore(list1, list2)");
            Console.WriteLine(Ignore(list1, list2).ToJson());
            Console.WriteLine();

            Console.WriteLine("Swap(list1, 2, 5)");
            Console.WriteLine(Swap(list1, 2, 5).ToJson());
            Console.WriteLine();
        }
    }
}
