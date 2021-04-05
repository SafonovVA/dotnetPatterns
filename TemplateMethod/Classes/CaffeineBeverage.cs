using System;

namespace TemplateMethod.Classes
{
    public abstract class CaffeineBeverage
    {
        public void Prepare()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        protected abstract void AddCondiments();
        protected abstract void Brew();

        private void PourInCup() => Console.WriteLine("Pouring into cup");
        private void BoilWater() => Console.WriteLine("Boiling water");
    }
}