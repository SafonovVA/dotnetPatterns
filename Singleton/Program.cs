using System;
using Singleton.Classes;

namespace Singleton
{
    static class Program
    {
        static void Main(string[] args)
        {
            var test = Classes.Singleton.GetInstance();
            test.Number = 5;
            Console.WriteLine("Number is {0}", test.Number);
            
            var test1 = Classes.Singleton.GetInstance();
            Console.WriteLine("Number is {0}", test1.Number);

        }
    }
}