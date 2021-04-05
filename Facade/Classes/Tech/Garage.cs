using System;

namespace Facade.Classes.Tech
{
    public class Garage
    {
        public void DoorOpen()
        {
            Console.WriteLine("Garage door is opened");
        }
        
        public void DoorClose()
        {
            Console.WriteLine("Garage door is closed");
        }
    }
}