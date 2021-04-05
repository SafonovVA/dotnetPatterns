using System;

namespace TemplateMethod.Classes
{
    public class Tea : CaffeineBeverage
    {
        protected override void AddCondiments() => Console.WriteLine("Adding lemon");
        protected override void Brew() => Console.WriteLine("Steeping the tea");
    }
}