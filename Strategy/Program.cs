using System;

using Strategy.Classes;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();

            Duck model = new ModelDuck();
            model.PerformFly();
            model.FlyBehavior = new FlyRocketPowered();
            model.PerformQuack();
            model.PerformFly();
        }

    }

}
