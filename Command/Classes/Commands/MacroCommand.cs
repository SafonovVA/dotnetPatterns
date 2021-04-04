using Command.Interfaces;

namespace Command.Classes.Commands
{
    public class MacroCommand : ICommand
    {
        private readonly ICommand[] _commands;

        public MacroCommand(ICommand[] commands)
        {
            _commands = commands;
        }

        public void Execute()
        {
            foreach (ICommand command in _commands)
            {
                command.Execute();
            }
        }

        public void Undo()
        {
            foreach (ICommand command in _commands)
            {
                command.Undo();
            }
        }
    }
}