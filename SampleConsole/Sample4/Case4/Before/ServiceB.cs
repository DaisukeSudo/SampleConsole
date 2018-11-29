using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsole.Sample4.Case4.Before
{
    public class ServiceB
    {
        public MixedStructure Get(string codeB)
        {
            return new MixedStructure()
            {
                DataType = "2",
                PropB = new MixedStructure.SubStructureB()
                {
                    CodeB = codeB,
                }
            };
        }
    }
}
