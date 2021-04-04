using System;
using Strategy.Interfaces;

namespace Strategy.Classes
{
    public class Quack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Quack");
        }
    }
}