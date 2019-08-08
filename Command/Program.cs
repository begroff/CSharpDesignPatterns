using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remote = new RemoteControl();
            Light light = new Light();
            LightOnCommand lightOn = new LightOnCommand(light);

            remote.SetCommand(lightOn);
            remote.ButtonWasPressed();
        }
    }
}
