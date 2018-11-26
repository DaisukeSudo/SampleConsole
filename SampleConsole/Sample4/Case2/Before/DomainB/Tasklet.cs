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
            var person = PersonService.Get("Taro");
            Console.WriteLine("His favorite fruit is an apple.");

            var fruitType = FruitShop.RecommendedOrder();
            Console.WriteLine("The recommended fruit is also an apple.");

            var result = IsFavoriteFruit(person, fruitType);
            Console.WriteLine($"Is match the favorite fruit ? => {result}");
        }

        public bool IsFavoriteFruit(Person person, FruitType fruitType) =>
            person.FavoriteFruit == (int)fruitType;
    }
}
