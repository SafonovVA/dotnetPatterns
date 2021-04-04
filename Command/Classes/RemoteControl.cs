using System;
using System.Text;
using Command.Classes.Commands;
using Command.Interfaces;

namespace Command.Classes
{
    public class RemoteControl
    {
        private readonly int _slotCount;
        private readonly ICommand[] _onCommand;
        private readonly ICommand[] _offCommand;
        private ICommand _undoCommand;

        public RemoteControl(int slotCount)
        {
            _slotCount = slotCount;
            _onCommand = new ICommand[slotCount];
            _offCommand = new ICommand[slotCount];

            Array.Fill(_onCommand, new NoCommand());
            Array.Fill(_offCommand, new NoCommand());
            _undoCommand = new NoCommand();
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            _onCommand[slot] = onCommand;
            _offCommand[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            _onCommand[slot].Execute();
            _undoCommand = _onCommand[slot];
        }

        public void OffButtonWasPushed(int slot)
        {
            _offCommand[slot].Execute();
            _undoCommand = _offCommand[slot];
        }
        
        public void UndoButtonWasPushed()
        {
            _undoCommand.Undo();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("\n----- Remote Control -----\n");
            for (int i = 0; i < _slotCount; i++)
            {
                sb.Append($"[slot {i}]\t{_onCommand[i].GetType().Name}\t{_offCommand[i].GetType().Name}\n");
            }
            return sb.ToString();
        }
    }
}