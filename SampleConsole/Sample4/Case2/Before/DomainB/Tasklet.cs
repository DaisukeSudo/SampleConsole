using System;
using System.Collections.Generic;
using System.Text;
using SampleConsole.Sample4.Case2.Before.DomainA;

namespace SampleConsole.Sample4.Case2.Before.DomainB
{
    public class Tasklet
    {
        private PersonService PersonService { get; }
        private FruitShop FruitShop { get; }

        public Tasklet(PersonService personService, FruitShop fruitShop)
        {
            PersonService = personService;
            FruitShop = fruitShop;
        }

        public void Run()
        {
            var taro = PersonService.Get("Taro");
            Console.WriteLine("Taro's favorite fruit is an apple");

            var apple = FruitShop.Order(taro.FavoriteFruit);
            Console.WriteLine($"The fruit ordered is {apple}");

            var joseph = PersonService.Get("Joseph");
            Console.WriteLine("Joseph's favorite fruit is a banana");

            var banana = FruitShop.Order(joseph.FavoriteFruit);
            Console.WriteLine($"The fruit ordered is {banana}");
        }
    }
}
