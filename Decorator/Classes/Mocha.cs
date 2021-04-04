namespace Decorator.Classes
{
    public class Mocha : CondimentDecorator
    {
        Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription() => beverage.GetDescription() + ", Mocha";

        public override double cost()
        {
            return beverage.cost() + .20;
        }
    }
}