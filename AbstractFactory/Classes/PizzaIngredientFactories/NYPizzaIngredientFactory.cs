using Factories.Classes.PizzaIngredientFactories.Ingredients;

namespace Factories.Classes.PizzaIngredientFactories
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public IDough createDough() => new ThinCrustDough();
        public ISause createSause() => new MarinaraSause();
    }
}