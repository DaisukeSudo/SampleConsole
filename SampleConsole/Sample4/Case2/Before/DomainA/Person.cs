using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsole.Sample4.Case2.Before.DomainA
{
    public class Person
    {
        public string Name { get; }
        public int FavoriteFruit { get; }

        public Person(string name, int favoriteFruit)
        {
            Name = name;
            FavoriteFruit = favoriteFruit;
        }
    }
}
