using AbstractFactory.Classes.PizzaIngredientFactories;
using AbstractFactory.Classes.Pizzas;

namespace AbstractFactory.Classes.PizzaStores
{
    public class NyPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new NyPizzaIngredientFactory();
            
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
            }
            return pizza;
        }
    }
}