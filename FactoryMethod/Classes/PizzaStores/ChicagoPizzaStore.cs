using System;
using FactoryMethod.Classes.Pizzas;

namespace FactoryMethod.Classes.PizzaStores
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            return type switch
            {
                "cheese" => new ChicagoStyleCheesePizza(),
                "veggie" => new ChicagoStyleVeggiePizza(),
                _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
            };
        }
    }
}