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

            // Turn living room light on then off
            remote.OnButtonWasPushed(0);
            remote.OffButtonWasPushed(0);
            Console.WriteLine(remote);

            // Undo the last command
            remote.UndoButtonWasPushed();

            // Turn living room light off then on
            remote.OffButtonWasPushed(0);
            remote.OnButtonWasPushed(0);
            Console.WriteLine(remote);

            // Undo the last command
            remote.UndoButtonWasPushed();

            // Turn the kitchen light on then off
            remote.OnButtonWasPushed(1);
            remote.OffButtonWasPushed(1);
        }
    }
}
