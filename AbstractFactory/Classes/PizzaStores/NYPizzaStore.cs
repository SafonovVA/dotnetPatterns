using Factories.Classes.PizzaIngredientFactories;
using Factories.Classes.Pizzas;

namespace Factories.Classes.PizzaStores
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza createPizza(string type)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();
            
            switch (type)
            {
                case "cheese":
                    pizza = new CheesePizza(ingredientFactory);
                    pizza.Name = "New York Style Cheese Pizza";
                    break;
                case "clam":
                    pizza = new ClamPizza(ingredientFactory);
                    pizza.Name = "New York Style Clam Pizza";
                    break;
            };
            return pizza;
        }
    }
}