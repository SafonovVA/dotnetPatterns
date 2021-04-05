using System;
using Adapter.Interfaces;

namespace Adapter.Classes
{
    public class WildTurkey : ITurkey
    {
        public void Gobble() => Console.WriteLine("Wild Turkey Gobble");

        public void Fly() => Console.WriteLine("Wild Turkey Fly");
    }
}