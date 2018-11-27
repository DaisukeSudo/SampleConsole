using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsole.Sample4.Case2.Before.DomainB
{
    public class FruitShop
    {
        private readonly Dictionary<int, string> Dict =
            new Dictionary<int, string>()
            {
                {1, "Apple" },
                {2, "Orange" },
                {3, "Banana" },
                {4, "Mango" },
                {5, "Kiwi" },
            };

        public string Order(int fruitType) => Dict[fruitType];
    }
}
