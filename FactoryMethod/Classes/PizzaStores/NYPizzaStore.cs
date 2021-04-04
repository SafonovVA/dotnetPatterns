using System;
using FactoryMethod.Classes.Pizzas;

namespace FactoryMethod.Classes.PizzaStores
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            return type switch
            {
                "cheese" => new NYStyleCheesePizza(),
                "veggie" => new NYStyleVeggiePizza(),
                _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
            };
        }
    }
}