using System;

namespace FactoryMethod.Classes.Pizzas
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            Name = "Chicago Style Sause and Cheese Pizza";
            Dough = "Extra Trick Crust Dough";
            Sause = "Plum Tomato Sause";
            
            toppings.Add("Shredded Mozzarella Cheese");
        }

        public override void cut()
        {
            Console.WriteLine("Cutting the pizza ingo square slices");
        }
    }
}