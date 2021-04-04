using AbstractFactory.Classes.PizzaIngredientFactories;
using AbstractFactory.Classes.Pizzas;

namespace AbstractFactory.Classes.PizzaStores
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
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
            }
            return pizza;
        }
    }
}