using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsole.Sample3.Case2
{
    public class Pin : IAnyItem, IVector2
    {
        public int Id { get; }
        public string Name { get; }
        public int X { get; }
        public int Y { get; }

        public Pin(int id, string name, int x, int y)
        {
            Id = id;
            Name = name;
            X = x;
            Y = y;
        }

        public override string ToString() => $"{{ Id: {Id}, Name: \"{Name}\", Vec: ({X}, {Y}) }}";
    }
}
