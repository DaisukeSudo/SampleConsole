using System;
using System.Collections.Generic;
using System.Text;
using SampleConsole.Sample3_5.Case1.AnyLibrary;

namespace SampleConsole.Sample3_5.Case1.AnyLibraryAdapter
{
    public class IndexAdapter
    {
        public Index Index { get; }
        public Converter Converter { get; } = new Converter();

        public IndexAdapter(Index index)
        {
            Index = index;
        }

        public OutParam Execute(InParam param)
        {
            var inParam = Converter.ConvertToInnerInParam(param);

            var result = Index.Execute(inParam);

            return Converter.ConvertToOuterOutParam(result);
        }
    }
}
