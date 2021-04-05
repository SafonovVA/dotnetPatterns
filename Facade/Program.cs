using System;
using Facade.Classes;
using Facade.Classes.Tech;

namespace Facade
{
    static class Program
    {
        static void Main()
        {
            var garage = new Garage();
            var smartHome = new SmartHomeFacade(garage: garage);
            Console.WriteLine("*----- Enable Tech -----*");
            smartHome.EnableTech();
            Console.WriteLine("\n*----- Disable Tech -----*");
            smartHome.DisableTech();
        }
    }
}