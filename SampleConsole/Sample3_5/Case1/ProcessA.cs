using System;
using System.Collections.Generic;
using System.Text;
using SampleConsole.Sample3_5.Case1.AnyLibraryAdapter;

namespace SampleConsole.Sample3_5.Case1
{
    public class ProcessA
    {
        public IndexAdapter Index { get; }
        
        public ProcessA(IndexAdapter index)
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
