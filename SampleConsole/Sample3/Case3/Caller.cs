using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SampleConsole.Sample3.Case3
{
    public class Caller
    {
        public static void Run()
        {
            Console.WriteLine("Case3 \n");

            var p = new BaseClass(10, "Janet");
            var sa = new SubClassA(20, "Sherry");
            var sb = new SubClassB(30, "Gloria");
            Console.WriteLine("> var p = new BaseClass(10, \"Janet\");");
            Console.WriteLine("> var sa = new SubClassA(20, \"Sherry\");");
            Console.WriteLine("> var sb = new SubClassA(30, \"Gloria\");");
            Console.WriteLine();

            Console.WriteLine("> p.CommonMethod()");
            p.CommonMethod();
            Console.WriteLine();

            Console.WriteLine("> sa.CommonMethod()");
            sa.CommonMethod();
            Console.WriteLine();

            //Console.WriteLine("> sa.OriginalMethodA()");
            //sa.OriginalMethodA();
            //Console.WriteLine();

            Console.WriteLine("> sb.CommonMethod()");
            sb.CommonMethod();
            Console.WriteLine();

            //Console.WriteLine("> sb.OriginalMethodA()");
            //sb.OriginalMethodB();
            //Console.WriteLine();

            Console.WriteLine("> Receiver.Do(sb)");
            Receiver.Do(sb);
            Console.WriteLine();

            Console.WriteLine("> ((BaseClass)sb).CommonMethod()");
            ((BaseClass)sb).CommonMethod();
            Console.WriteLine();
        }
    }
}
