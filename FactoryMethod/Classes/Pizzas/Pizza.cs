using System;
using System.Collections.Generic;

namespace FactoryMethod.Classes.Pizzas
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public string Dough { get; set; }
        public string Sause { get; set; }

        protected List<string> toppings = new List<string>();
        
        public void prepare()
        {
            Console.WriteLine("Preparing {0}", Name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sause...");
            Console.WriteLine("Adding toppings...");
            foreach (string topping in toppings)
            {
                Console.WriteLine("   {0}", topping);
            }
        }

        public virtual void bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public virtual void box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }
    }
}