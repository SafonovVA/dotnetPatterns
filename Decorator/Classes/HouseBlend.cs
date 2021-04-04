namespace Decorator.Classes
{
    public class HouseBlend : Beverage
    {
        public override string GetDescription() => "House Blend Coffee";

        public override double cost() => .89;
    }
}