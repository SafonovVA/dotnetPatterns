using Factories.Classes.PizzaIngredientFactories.Ingredients;

namespace Factories.Classes.PizzaIngredientFactories
{
    public interface IPizzaIngredientFactory
    {
        public IDough createDough(); 
        public ISause createSause();
    }
}