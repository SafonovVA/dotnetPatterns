using System;
using Strategy.Interfaces;

namespace Strategy.Classes
{
    public class FlyWithWings : IFlyBehavior
    {
        public void fly() 
        {
            Console.WriteLine("I'm flying with wings");
        }
    }
}