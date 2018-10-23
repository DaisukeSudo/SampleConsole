using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;

namespace SampleConsole.Sample3.Case1
{
    public static class Applicability
    {
        public static int Double(int x) => x * 2;

        public static double Distance(Vector2 a, Vector2 b) =>
            Sqrt(Pow(a.X - b.X, 2) + Pow(a.Y - b.Y, 2));
    }
}
