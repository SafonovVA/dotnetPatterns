using System;
using Strategy.Interfaces;

namespace Strategy.Classes
{
    public class Squeak : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}