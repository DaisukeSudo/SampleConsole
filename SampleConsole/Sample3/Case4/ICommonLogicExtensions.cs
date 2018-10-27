using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsole.Sample3.Case4
{
    public static class ICommonLogicExtensions
    {
        public static string Hello(this ICommonLogic _this, string name) => $"ＨＥＬＬＯ {name}";
    }
}
