using System;
using System.Collections.Generic;
using Factories.Classes.PizzaIngredientFactories.Ingredients;

namespace Factories.Classes.Pizzas
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public IDough Dough { get; set; }
        public ISause Sause { get; set; }

        protected List<string> toppings = new List<string>();

        public abstract void prepare();

        public void bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }                           
        
        public void cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }                           
        
        public void box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }
    }
}
