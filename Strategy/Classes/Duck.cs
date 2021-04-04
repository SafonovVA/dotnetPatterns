using Strategy.Interfaces;

namespace Strategy.Classes
{
    public abstract class Duck
    {
        public IFlyBehavior FlyBehavior {get; set;}
        public IQuackBehavior QuackBehavior {get; set;}

        public Duck() {}

        public abstract void display();

        public void PerformFly()
        {
            FlyBehavior.fly();
        }

        public void PerformQuack()
        {
            QuackBehavior.quack();
        }

        public void swim()
        {
            System.Console.WriteLine("All ducks float, even decoys!");
        }
    }
}