using System;
using Adapter.Interfaces;

namespace Adapter.Classes
{
    public class MallardDuck : IDuck
    {
        public void Quack() => Console.WriteLine("Mallard Duck Quack");
        public void Fly() => Console.WriteLine("Mallard Duck Fly");
    }
}