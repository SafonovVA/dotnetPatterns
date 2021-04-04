using System;
using Factories.Classes.PizzaIngredientFactories;

namespace Factories.Classes.Pizzas
{
    class ChicagoStyleCheesePizza : Pizza
    {
        private IPizzaIngredientFactory ingredientFactory;
        public ChicagoStyleCheesePizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }
        
        public override void prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Dough = ingredientFactory.createDough();
            Sause = ingredientFactory.createSause();
        } 
    }
}
