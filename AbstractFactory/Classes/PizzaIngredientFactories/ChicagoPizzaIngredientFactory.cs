using AbstractFactory.Classes.PizzaIngredientFactories.Ingredients;

namespace AbstractFactory.Classes.PizzaIngredientFactories
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public IDough CreateDough() => new CalSomeDough();
        public ISause CreateSause() => new OtherSause();
    }
}