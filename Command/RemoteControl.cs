using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    public class RemoteControl
    {
        List<ICommand> onCommands;
        List<ICommand> offCommands;
        ICommand undoCommand;

        public RemoteControl()
        {
            onCommands = new List<ICommand>(7);
            offCommands = new List<ICommand>(7);

            ICommand noCommand = new NoCommand();
            for (int i = 0; i < 7; i++)
            {
                onCommands.Add(noCommand);
                offCommands.Add(noCommand);
        }

            undoCommand = noCommand;
        }

        public void SetCommand(int position, ICommand onCommand, ICommand offCommand)
        {
            onCommands.RemoveAt(position);
            onCommands.Insert(position, onCommand);

            offCommands.RemoveAt(position);
            offCommands.Insert(position, offCommand);
        }

        public void OnButtonWasPushed(int position)
        {
            onCommands[position].Execute();
            undoCommand = onCommands[position];
        }

        public void OffButtonWasPushed(int position)
        {
            offCommands[position].Execute();
            undoCommand = offCommands[position];
        }

        public void UndoButtonWasPushed() {
            undoCommand.Undo();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n------- Remote Control -------\n");

            for (int i = 0; i < onCommands.Count; i++)
            {
                sb.AppendLine(
                    $"[slot {i}] {onCommands[i].GetType().Name} {offCommands[i].GetType().Name}");
            }

            sb.AppendLine(
                $"[undo] {undoCommand.GetType().Name}"
            );

            return sb.ToString();
        }
    }
}
