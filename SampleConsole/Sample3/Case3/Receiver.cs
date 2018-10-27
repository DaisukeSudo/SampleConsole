using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsole.Sample3.Case3
{
    public static class Receiver
    {
        public static void Do(BaseClass obj)
        {
            obj.CommonMethod();
        }
    }
}
