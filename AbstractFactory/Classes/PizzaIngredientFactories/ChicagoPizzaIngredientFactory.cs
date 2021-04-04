using Factories.Classes.PizzaIngredientFactories.Ingredients;

namespace Factories.Classes.PizzaIngredientFactories
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public IDough createDough() => new CalSomeDough();
        public ISause createSause() => new OtherSause();
    }
}