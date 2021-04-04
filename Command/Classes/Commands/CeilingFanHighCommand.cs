using System;
using Command.Classes.Technic;
using Command.Interfaces;

namespace Command.Classes.Commands
{
    public class CeilingFanHighCommand : CeilingFanCommand
    {
        public CeilingFanHighCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }
        public override void Execute()
        {
            _prevSpeed = _ceilingFan.CurrentSpeed;
            _ceilingFan.High();
        }
    }
}