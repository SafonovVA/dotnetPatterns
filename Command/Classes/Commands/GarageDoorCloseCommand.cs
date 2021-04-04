using Command.Classes.Technic;
using Command.Interfaces;

namespace Command.Classes.Commands
{
    public class GarageDoorCloseCommand : ICommand
    {
        private readonly Garage _garage;

        public GarageDoorCloseCommand(Garage garage) => _garage = garage;

        public void Execute()
        {
            _garage.Down();
            _garage.LightOff();
        }

        public void Undo()
        {
            _garage.Up();
            _garage.LightOn();
        }
    }
}