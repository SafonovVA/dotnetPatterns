using System;
using AbstractFactory.Classes.Pizzas;
using AbstractFactory.Classes.PizzaStores;

namespace AbstractFactory
{
    class Program
    {
        static void Main()
        {
            PizzaStore nyStore = new NyPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine($"Order {pizza.Name}");

            Console.WriteLine();

            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine($"Order {pizza.Name}");
        }
    }
}
