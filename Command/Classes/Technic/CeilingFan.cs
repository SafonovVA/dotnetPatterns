using System;

namespace Command.Classes.Technic
{
    public class CeilingFan
    {
        public enum Speed
        {
            Off, Low, Medium, High
        }

        private string _location;
        private Speed _speed;
        public Speed CurrentSpeed => _speed;

        public CeilingFan(string location)
        {
            _location = location;
            _speed = Speed.Off;
        }

        public void Off()
        {
            _speed = Speed.Off;
            PrintCurrentSpeed();
        }

        public void Low()
        {
            _speed = Speed.Low;
            PrintCurrentSpeed();
        }

        public void Medium()
        {
            _speed = Speed.Medium;
            PrintCurrentSpeed();
        }

        public void High()
        {
            _speed = Speed.High;
            PrintCurrentSpeed();
        }

        private void PrintCurrentSpeed()
        {
            Console.WriteLine($"Ceiling fan speed is {(int)_speed}");
        }
    }
}