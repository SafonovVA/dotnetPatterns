using System;

namespace Strategy.Classes
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new Quack();
        }
        public override void display()
        {
            Console.WriteLine("I'm real mallard duck!");
        }
    }
}