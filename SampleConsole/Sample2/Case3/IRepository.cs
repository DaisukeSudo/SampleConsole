using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsole.Sample2.Case3
{
    public interface IRepository
    {
        IEnumerable<Source> SelectTargetSources(string key);
    }
}
