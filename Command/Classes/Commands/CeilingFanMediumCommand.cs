using Command.Classes.Technic;

namespace Command.Classes.Commands
{
    public class CeilingFanMediumCommand : CeilingFanCommand
    {
        public CeilingFanMediumCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }
        public override void Execute()
        {
            _prevSpeed = _ceilingFan.CurrentSpeed;
            _ceilingFan.Medium();
        }
    }
}