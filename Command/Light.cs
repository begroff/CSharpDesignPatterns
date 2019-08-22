using System;

namespace Command
{
    public class Light
    {
        private string lightType;
        public Light(string lightType)
        {
            this.lightType = lightType;
        }

        public void On()
        {
            Console.WriteLine($"{lightType} light is on");
        }

        public void Off()
        {
            Console.WriteLine($"{lightType} light is off");
        }
    }
}
