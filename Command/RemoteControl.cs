using System;

namespace Command
{
    public class RemoteControl
    {
        ICommand button;

        public RemoteControl()
        {

        }

        public void SetCommand(ICommand command)
        {
            button = command;
        }

        public void ButtonWasPressed()
        {
            button.Execute();
        }
    }
}
