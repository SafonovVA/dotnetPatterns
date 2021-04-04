using Factories.Classes.PizzaIngredientFactories;
using Factories.Classes.Pizzas;

namespace Factories.Classes.PizzaStores
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza createPizza(string type)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();
            
            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza(ingredientFactory);
                    pizza.Name = "Chicago Style Cheese Pizza";
                    break;
                case "clam":
                    pizza = new ClamPizza(ingredientFactory);
                    pizza.Name = "Chicago Style Clam Pizza";
                    break;
            };
            return pizza;
        }
    }
}