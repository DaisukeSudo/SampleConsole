using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsole.Sample4.Case4.Before
{
    public class ServiceC
    {
        public MixedStructure Get(string codeC)
        {
            return new MixedStructure()
            {
                DataType = "3",
                PropC = new MixedStructure.SubStructureC()
                {
                    CodeC = codeC,
                }
            };
        }
    }
}
