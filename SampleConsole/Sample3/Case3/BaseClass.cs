using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsole.Sample3.Case3
{
    public class BaseClass
    {
        public int Id { get; }
        public string Name { get; }

        public BaseClass(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void CommonMethod() {}
    }
}
