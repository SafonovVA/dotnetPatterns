namespace FactoryMethod.Classes.Pizzas
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            Name = "NY Style Sause and Cheese Pizza";
            Dough = "Thin Crust Dough";
            Sause = "Marinara Sause";
            
            toppings.Add("Grated Reggano Cheese");
        }
    }
}