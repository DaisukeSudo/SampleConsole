using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsole.Sample4.Case2.Before.DomainA
{
    public class PersonService
    {
        public Person Get(string id) => new Person(id, id.Length % 4 + 1);
    }
}
