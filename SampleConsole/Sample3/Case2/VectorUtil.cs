﻿using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;

namespace SampleConsole.Sample3.Case2
{
    public static class VectorUtil
    {
        public static double Distance(IVector2 a, IVector2 b) =>
            Sqrt(Pow(a.X - b.X, 2) + Pow(a.Y - b.Y, 2));
    }
}
