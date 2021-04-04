using System;
using System.Collections.Generic;
using AbstractFactory.Classes.PizzaIngredientFactories.Ingredients;

namespace AbstractFactory.Classes.Pizzas
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        protected IDough Dough { get; set; }
        protected ISause Sause { get; set; }

        protected List<string> Toppings = new List<string>();

        public abstract void Prepare();

        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }                           
        
        public void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }                           
        
        public void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }
    }
}
