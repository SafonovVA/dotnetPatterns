using Command.Classes.Technic;
using Command.Interfaces;

namespace Command.Classes.Commands
{
    public class CeilingFanOffCommand : CeilingFanCommand
    {
        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }
        public override void Execute()
        {
            _prevSpeed = _ceilingFan.CurrentSpeed;
            _ceilingFan.Off();
        }
    }
}