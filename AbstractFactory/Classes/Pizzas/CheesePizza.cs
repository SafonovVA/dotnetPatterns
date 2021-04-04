using System;
using AbstractFactory.Classes.PizzaIngredientFactories;

namespace AbstractFactory.Classes.Pizzas
{
    class CheesePizza : Pizza
    {
        private readonly IPizzaIngredientFactory _ingredientFactory;
        public CheesePizza(IPizzaIngredientFactory ingredientFactory)
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