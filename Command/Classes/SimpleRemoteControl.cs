using Command.Interfaces;

namespace Command.Classes
{
    public class SimpleRemoteControl
    {
        private ICommand _slot;
        public void SetCommand(ICommand command)
        {
            _slot = command;
        }

        public void ButtonWasPressed()
        {
            _slot.Execute();
        }
    }
}