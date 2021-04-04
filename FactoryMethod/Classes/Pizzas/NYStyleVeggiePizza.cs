namespace FactoryMethod.Classes.Pizzas
{
    public class NYStyleVeggiePizza : Pizza
    {
        public NYStyleVeggiePizza()
        {
            Name = "NY Style Veggie Pizza";
            Dough = "Thin Veggie Dough";
            Sause = "Veggie Sause";
            
            toppings.Add("Grated Veggie Cheese");
        }
    }
}