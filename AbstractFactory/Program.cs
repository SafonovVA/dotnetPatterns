using System;
using Factories.Classes.Pizzas;
using Factories.Classes.PizzaStores;

namespace Factories
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.orderPizza("cheese");
            Console.WriteLine($"Order {pizza.Name}");

            Console.WriteLine();

            pizza = chicagoStore.orderPizza("cheese");
            Console.WriteLine($"Order {pizza.Name}");
        }
    }
}
