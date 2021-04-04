using System;
using Strategy.Interfaces;

namespace Strategy.Classes
{
    public class FlyRocketPowered : IFlyBehavior
    {
        public void fly()
        {
            Console.WriteLine("I'm flying with a rocket!");
        }
    }
}