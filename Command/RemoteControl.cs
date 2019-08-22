using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class RemoteControl
    {
        List<ICommand> OnCommands;
        List<ICommand> OffCommands;

        public RemoteControl()
        {
            OnCommands = new List<ICommand>(7);
            OffCommands = new List<ICommand>(7);

            ICommand noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                OnCommands.Add(noCommand);
                OffCommands.Add(noCommand);
            }
        }

        public void SetCommand(int position, ICommand onCommand, ICommand offCommand)
        {
            OnCommands.RemoveAt(position);
            OnCommands.Insert(position, onCommand);

            OffCommands.RemoveAt(position);
            OffCommands.Insert(position, offCommand);
        }

        public void OnButtonWasPushed(int position)
        {
            OnCommands[position].Execute();
        }

        public void OffButtonWasPushed(int position)
        {
            OffCommands[position].Execute();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n------- Remote Control -------\n");

            for (int i = 0; i < OnCommands.Count; i++)
            {
                sb.AppendLine(
                    $"[slot {i}] {OnCommands[i].GetType().Name} {OffCommands[i].GetType().Name}");
            }

            return sb.ToString();
        }
    }
}
