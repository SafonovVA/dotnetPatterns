namespace Decorator.Classes
{
    public class Espresso : Beverage
    {
        public override string GetDescription() => "Espresso";

        public override double cost() => 1.99;
    }
}