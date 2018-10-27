using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsole.Sample3.Case4
{
    public class Director
    {
        private CommonModel Model { get; }

        public Director(CommonModel model)
        {
            Model = model;
        }

        public void CommonProc()
        {
            Model.CommonProc();
        }
    }
}
