using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remote = new RemoteControl();

            Light livingRoomLight = new Light("Living Room");
            Light kitchenLight = new Light("Kitchen");

            LightOnCommand livingRoomLightOn =
                new LightOnCommand(livingRoomLight);

            LightOffCommand livingRoomLightOff =
                new LightOffCommand(livingRoomLight);

            LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);

            remote.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remote.SetCommand(1, kitchenLightOn, kitchenLightOff);

            Console.WriteLine(remote);

            remote.OnButtonWasPushed(0);
            remote.OffButtonWasPushed(0);
            remote.OnButtonWasPushed(1);
            remote.OffButtonWasPushed(1);
        }
    }
}
