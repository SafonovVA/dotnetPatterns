using System;
using FactoryMethod.Classes.Pizzas;

namespace FactoryMethod.Classes.PizzaStores
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(string type)
        {
            var pizza = CreatePizza(type);
            
            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();
            Console.WriteLine();
            return pizza;
        }

        protected abstract Pizza CreatePizza(string type);
    }
}