using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SampleConsole.Sample3.Case4
{
    public class Caller
    {
        public static void Run()
        {
            Console.WriteLine("Case4 \n");

            var successor = new Successor();
            Console.WriteLine("var successor = new Successor()");
            Console.WriteLine("successor.CommonProc()");
            successor.CommonProc();
            Console.WriteLine();

            var director = new Director(new CommonModel());
            Console.WriteLine("var director = new Director(new CommonUtil())");
            Console.WriteLine("director.CommonProc()");
            director.CommonProc();
            Console.WriteLine();

            var mixture = new Mixture();
            Console.WriteLine("var mixture = new Mixture()");
            Console.WriteLine("mixture.Hello(\"World\")");
            Console.WriteLine(mixture.Hello("World"));
            Console.WriteLine();
        }
    }
}
