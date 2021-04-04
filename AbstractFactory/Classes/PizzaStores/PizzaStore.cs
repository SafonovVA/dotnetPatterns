using Factories.Classes.Pizzas;

namespace Factories.Classes.PizzaStores
{
    public abstract class PizzaStore
    {
        public Pizza orderPizza(string type)
        {
            Pizza pizza = createPizza(type);
            
            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }

        public abstract Pizza createPizza(string type);
    }
}