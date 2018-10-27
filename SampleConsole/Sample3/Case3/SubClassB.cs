using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsole.Sample3.Case3
{
    public class SubClassB : BaseClass
    {
        public SubClassB(int id, string name) : base(id, name) { }

        public void OriginalMethodB() => Console.WriteLine("This is OriginalMethodB");

        public override void CommonMethod() => Console.WriteLine($"Hi! I'm {Name}. My ID is {Id}.");
    }
}
