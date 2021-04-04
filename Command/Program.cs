using System;
using Command.Classes;
using Command.Classes.Commands;
using Command.Classes.Technic;

namespace Command
{
    static class Program
    {
        static void Main()
        {
            UseSimpleRemoteControl();
            UseRemoteControl();
        }

        static void UseRemoteControl()
        {
            var remote = new RemoteControl(7);
            
            var light = new Light();
            var lightOnCommand = new LightOnCommand(light);
            var lightOffCommand = new LightOffCommand(light);

            var garage = new Garage();
            var garageDoorOpenCommand = new GarageDoorOpenCommand(garage);
            var garageDoorCloseCommand = new GarageDoorCloseCommand(garage);

            var ceilingFan = new CeilingFan("Living room");
            var ceilingFanOffCommand = new CeilingFanOffCommand(ceilingFan);
            var ceilingFanLowCommand = new CeilingFanLowCommand(ceilingFan);
            var ceilingFanMediumCommand = new CeilingFanMediumCommand(ceilingFan);
            var ceilingFanHighCommand = new CeilingFanHighCommand(ceilingFan);
            
            remote.SetCommand(0, lightOnCommand, lightOffCommand);
            remote.SetCommand(1, garageDoorOpenCommand, garageDoorCloseCommand);
            remote.SetCommand(2, ceilingFanLowCommand, ceilingFanOffCommand);
            remote.SetCommand(3, ceilingFanMediumCommand, ceilingFanOffCommand);
            remote.SetCommand(4, ceilingFanHighCommand, ceilingFanOffCommand);
            
            Console.WriteLine(remote.ToString());
            
            remote.OnButtonWasPushed(0);
            remote.OffButtonWasPushed(0);
            remote.UndoButtonWasPushed();
            
            remote.OnButtonWasPushed(1);
            remote.OffButtonWasPushed(1);
            remote.UndoButtonWasPushed();
            
            remote.OnButtonWasPushed(2);
            remote.OffButtonWasPushed(2);
            remote.UndoButtonWasPushed();
            remote.OnButtonWasPushed(4);
            remote.OffButtonWasPushed(4);
            remote.UndoButtonWasPushed();
        }
        static void UseSimpleRemoteControl()
        {
            var remote = new SimpleRemoteControl();
            
            var lightOnCommand = new LightOnCommand(new Light());
            var garageDoorOpenCommand = new GarageDoorOpenCommand(new Garage());
            
            remote.SetCommand(lightOnCommand);
            remote.ButtonWasPressed();
            
            remote.SetCommand(garageDoorOpenCommand);
            remote.ButtonWasPressed();
        }
    }
}