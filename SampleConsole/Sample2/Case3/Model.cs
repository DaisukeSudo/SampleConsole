using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsole.Sample2.Case3
{
    public class Model
    {
        public static ModelFactory Factory { get; } = new ModelFactory();

        // Any fields ...

        public bool IsEnabled { get; }
    }
}
