using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsole.Sample4
{
    public class Tasklet
    {
        public void Run()
        {
            new Case2.Before.DomainB.Tasklet(new Case2.Before.DomainA.PersonService(), new Case2.Before.DomainB.FruitShop()).Run();

            Console.ReadKey();
        }
    }
}
