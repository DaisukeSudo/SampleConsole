using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsole.Sample3_5.Case1.AnyLibraryAdapter
{
    public class Converter
    {
        public AnyLibrary.InParam ConvertToInnerInParam(InParam param) => new AnyLibrary.InParam();

        public OutParam ConvertToOuterOutParam(AnyLibrary.OutParam param) => new OutParam();
    }
}
