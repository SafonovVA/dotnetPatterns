using Command.Classes.Technic;
using Command.Interfaces;

namespace Command.Classes.Commands
{
    public class GarageDoorOpenCommand : ICommand
    {
        private readonly Garage _garage;

        public GarageDoorOpenCommand(Garage garage) => _garage = garage;

        public void Execute()
        {
            _garage.Up();
            _garage.LightOn();
        }

        public void Undo()
        {
            _garage.Down();
            _garage.LightOff();
        }
    }
}