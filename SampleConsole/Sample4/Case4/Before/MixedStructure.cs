using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsole.Sample4.Case4.Before
{
    public class MixedStructure
    {
        public string DataType { get; set; }
        public SubStructureA PropA { get; set; }
        public SubStructureB PropB { get; set; }
        public SubStructureC PropC { get; set; }

        public class SubStructureA
        {
            public string CodeA { get; set; }
        }

        public class SubStructureB
        {
            public string CodeB { get; set; }
        }

        public class SubStructureC
        {
            public string CodeC { get; set; }
        }
    }
}
