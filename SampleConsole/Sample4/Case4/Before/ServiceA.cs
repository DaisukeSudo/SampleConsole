using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsole.Sample4.Case4.Before
{
    public class ServiceA
    {
        public MixedStructure Get(string codeA)
        {
            return new MixedStructure()
            {
                DataType = "1",
                PropA = new MixedStructure.SubStructureA()
                {
                    CodeA = codeA,
                }
            };
        }
    }
}
