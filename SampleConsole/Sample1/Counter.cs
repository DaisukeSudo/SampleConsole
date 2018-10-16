using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsole.Sample1
{
    public class Counter
    {
        private int _value = 0;

        public int GetValue() => _value++;
    }
}
