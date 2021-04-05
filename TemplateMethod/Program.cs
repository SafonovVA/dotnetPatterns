using System;
using TemplateMethod.Classes;

namespace TemplateMethod
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*----- Tea -----*");
            var tea = new Tea();
            tea.Prepare();
            
            Console.WriteLine("\n*----- Coffee -----*");
            var coffee = new Coffee();
            coffee.Prepare();
        }
    }
}