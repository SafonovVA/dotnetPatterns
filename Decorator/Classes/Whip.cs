namespace Decorator.Classes
{
    public class Whip : CondimentDecorator
    {
        Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription() => beverage.GetDescription() + ", Whip";

        public override double cost()
        {
            return beverage.cost() + .40;
        }
    }
}