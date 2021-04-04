using System;
using Strategy.Interfaces;

namespace Strategy.Classes
{
    public class MuteQuack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("<< Silense >>");
        }
    }
}