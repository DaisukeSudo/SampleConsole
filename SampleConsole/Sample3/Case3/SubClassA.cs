using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsole.Sample3.Case3
{
    public class SubClassA : BaseClass
    {
        public SubClassA(int id, string name) : base(id, name) {}

        public void OriginalMethodA() { }
    }
}
