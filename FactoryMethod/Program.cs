using FactoryMethod.Classes.PizzaStores;

namespace FactoryMethod
{
    static class Program
    {
        static void Main()
        {
            var nyPizzaStore = new NYPizzaStore();
            nyPizzaStore.OrderPizza("cheese");
            nyPizzaStore.OrderPizza("veggie");
            
            var chicagoPizzaStore = new ChicagoPizzaStore();
            chicagoPizzaStore.OrderPizza("cheese");
            chicagoPizzaStore.OrderPizza("veggie");
        }
    }
}