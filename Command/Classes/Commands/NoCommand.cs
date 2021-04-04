using System;
using Command.Interfaces;

namespace Command.Classes.Commands
{
    public class NoCommand : ICommand
    {
        public void Execute() => Console.WriteLine("To tech");
        public void Undo() => Console.WriteLine("To tech");
    }
}