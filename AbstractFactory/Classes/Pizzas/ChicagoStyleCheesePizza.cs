using System;
using AbstractFactory.Classes.PizzaIngredientFactories;

namespace AbstractFactory.Classes.Pizzas
{
    class ChicagoStyleCheesePizza : Pizza
    {
        private readonly IPizzaIngredientFactory _ingredientFactory;
        public ChicagoStyleCheesePizza(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }
        
        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Dough = _ingredientFactory.CreateDough();
            Sause = _ingredientFactory.CreateSause();
        } 
    }
}
