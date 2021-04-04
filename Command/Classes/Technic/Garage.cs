using System;

namespace Command.Classes.Technic
{
    public class Garage
    {
        public void Up() => Console.WriteLine("Garage door is open.");
        public void Down() => Console.WriteLine("Garage door is closed.");
        public void Stop() => Console.WriteLine("Garage door stop.");
        public void LightOn() => Console.WriteLine("Garage light on.");
        public void LightOff() => Console.WriteLine("Garage light off.");
    }
}