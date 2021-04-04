using System;
using Strategy.Interfaces;

namespace Strategy.Classes
{
    public class FlyNoWay : IFlyBehavior
    {
        public void fly() 
        {
            Console.WriteLine("I can't fly");
        }
    }
}