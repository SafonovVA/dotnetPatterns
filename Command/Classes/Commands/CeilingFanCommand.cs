using System;
using Command.Classes.Technic;
using Command.Interfaces;

namespace Command.Classes.Commands
{
    public abstract class CeilingFanCommand : ICommand
    {
        protected CeilingFan _ceilingFan;
        protected CeilingFan.Speed _prevSpeed;
        public abstract void Execute();
        public void Undo()
        {
            switch (_prevSpeed)
            {
                case CeilingFan.Speed.Off:
                    _ceilingFan.Off();
                    break;
                case CeilingFan.Speed.Low:
                    _ceilingFan.Low();
                    break;
                case CeilingFan.Speed.Medium:
                    _ceilingFan.Medium();
                    break;
                case CeilingFan.Speed.High:
                    _ceilingFan.High();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}