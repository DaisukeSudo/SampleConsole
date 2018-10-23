using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsole.Sample3.Case2
{
    public class Vector2 : IVector2
    {
        public int X { get; }
        public int Y { get; }

        public Vector2(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString() => $"({X}, {Y})";
    }
}
