using System;

namespace FactoryMethod.Classes.Pizzas
{
    public class ChicagoStyleVeggiePizza : Pizza
    {
        public ChicagoStyleVeggiePizza()
        {
            Name = "Chicago Style Veggie Pizza";
            Dough = "Extra Trick Veggie Dough";
            Sause = "Plum Veggie Sause";
            
            toppings.Add("Shredded Veggie Cheese");
        }

        public override void cut()
        {
            Console.WriteLine("Cutting the pizza ingo square slices");
        }
    }
}