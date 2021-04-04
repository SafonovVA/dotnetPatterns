using AbstractFactory.Classes.PizzaIngredientFactories.Ingredients;

namespace AbstractFactory.Classes.PizzaIngredientFactories
{
    public class NyPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public IDough CreateDough() => new ThinCrustDough();
        public ISause CreateSause() => new MarinaraSause();
    }
}