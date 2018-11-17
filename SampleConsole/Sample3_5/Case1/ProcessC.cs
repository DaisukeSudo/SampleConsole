using System;
using System.Collections.Generic;
using System.Text;
using SampleConsole.Sample3_5.Case1.AnyLibraryAdapter;

namespace SampleConsole.Sample3_5.Case1
{
    public class ProcessC
    {
        public IndexAdapter Index { get; }

        public ProcessC(IndexAdapter index)
        {
            Index = index;
        }

        public void AnyProc()
        {
            var param = new InParam();

            var result = Index.Execute(param);

            // ...
        }
    }
}
