using Command.Classes.Technic;

namespace Command.Classes.Commands
{
    public class CeilingFanLowCommand : CeilingFanCommand
    {
        public CeilingFanLowCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }
        public override void Execute()
        {
            _prevSpeed = _ceilingFan.CurrentSpeed;
            _ceilingFan.Low();
        }
    }
}