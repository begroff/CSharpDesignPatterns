using System;

namespace Command
{
    public class CeilingFan
    {
        public int HIGH { get; } = 3;
        public int MEDIUM { get; } = 2;
        public int LOW { get; } = 1;
        public int OFF { get; } = 0;

        private string location;
        private int speed;

        public CeilingFan(string location)
        {
            this.location = location;
            speed = OFF;
        }

        public void High() {
            speed = HIGH;
            Console.WriteLine($"{location} ceiling fan is on high");
        }

        public void Medium() {
            speed = MEDIUM;
            Console.WriteLine($"{location} ceiling fan is on medium");
        }

        public void Low() {
            speed = LOW;
            Console.WriteLine($"{location} ceiling fan is on low");
        }

        public void Off() {
            speed = OFF;
            Console.WriteLine($"{location} ceiling fan is off");
        }

        public int GetSpeed() {
            return speed;
        }
    }
}
