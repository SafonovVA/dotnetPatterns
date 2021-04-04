using AbstractFactory.Classes.PizzaIngredientFactories.Ingredients;

namespace AbstractFactory.Classes.PizzaIngredientFactories
{
    public interface IPizzaIngredientFactory
    {
        public IDough CreateDough(); 
        public ISause CreateSause();
    }
}