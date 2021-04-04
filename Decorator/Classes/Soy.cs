namespace Decorator.Classes
{
    public class Soy : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription() => _beverage.GetDescription() + ", Soy";

        public override double cost()
        {
            return _beverage.cost() + .30;
        }
    }
}