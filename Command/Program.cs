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

            Console.WriteLine();

            CeilingFan ceilingFan = new CeilingFan("Living Room");

            CeilingFanMediumCommand ceilingFanMedium =
                new CeilingFanMediumCommand(ceilingFan);

            CeilingFanHighCommand ceilingFanHigh =
                new CeilingFanHighCommand(ceilingFan);

            CeilingFanOffCommand ceilingFanOff =
                new CeilingFanOffCommand(ceilingFan);

            remote.SetCommand(2, ceilingFanMedium, ceilingFanOff);
            remote.SetCommand(3, ceilingFanHigh, ceilingFanOff);

            remote.OnButtonWasPushed(2);
            remote.OffButtonWasPushed(2);
            Console.WriteLine(remote);
            remote.UndoButtonWasPushed();

            remote.OnButtonWasPushed(3);
            Console.WriteLine(remote);
            remote.UndoButtonWasPushed();

            Light light = new Light("Living Room");
            TV tv = new TV("Living Room");
            Stereo stereo = new Stereo("Living Room");
            Hottub hottub = new Hottub();

            LightOnCommand lightOn = new LightOnCommand(light);
            StereoOnCommand stereoOn = new StereoOnCommand(stereo);
            TVOnCommand tvOn = new TVOnCommand(tv);
            HottubOnCommand hottubOn = new HottubOnCommand(hottub);

            LightOffCommand lightOff = new LightOffCommand(light);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);
            TVOffCommand tvOff = new TVOffCommand(tv);
            HottubOffCommand hottubOff = new HottubOffCommand(hottub);

            ICommand[] partyOn = { lightOn, stereoOn, tvOn, hottubOn };
            ICommand[] partyOff = { lightOff, stereoOff, tvOff, hottubOff };

            MacroCommand partyOnMacro = new MacroCommand(partyOn);
            MacroCommand partyOffMacro = new MacroCommand(partyOff);

            remote.SetCommand(4, partyOnMacro, partyOffMacro);

            Console.WriteLine(remote);
            remote.OnButtonWasPushed(4);
            remote.OffButtonWasPushed(4);
        }
    }
}
