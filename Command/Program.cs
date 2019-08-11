using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remote = new RemoteControl();
            Light light = new Light();
            GarageDoor garageDoor = new GarageDoor();
            LightOnCommand lightOn = new LightOnCommand(light);
            GarageDoorOpenCommand garageOpen = new GarageDoorOpenCommand(garageDoor);

            remote.SetCommand(lightOn);
            remote.ButtonWasPressed();
            remote.SetCommand(garageOpen);
            remote.ButtonWasPressed();
        }
    }
}
