using Adapter.Classes;
using Adapter.Interfaces;

namespace Adapter
{
    static class Program
    {
        static void Main()
        {
            var duck = new MallardDuck();
            var turkey = new WildTurkey();

            var adaptiveTurkey = new TurkeyAdapter(turkey);
            IDuck[] ducks = { duck, adaptiveTurkey };

            foreach (IDuck bird in ducks)
            {
                bird.Quack();
                bird.Fly();
            }
        }
    }
}