using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsole
{
    public static class Extensions
    {
        public static string ToJson<T>(this IEnumerable<T>  list) => $"[{string.Join(", ", list)}]";
    }
}
