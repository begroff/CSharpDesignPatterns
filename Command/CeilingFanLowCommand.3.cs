using System;

namespace Command
{
    public class CeilingFanLowCommand : ICommand
    {
        private CeilingFan ceilingFan;
        private int previousSpeed;

        public CeilingFanLowCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            previousSpeed = ceilingFan.GetSpeed();
            ceilingFan.Low();
        }

        public void Undo()
        {
            if (previousSpeed == ceilingFan.HIGH)
            {
                ceilingFan.High();
            }
            else if (previousSpeed == ceilingFan.MEDIUM)
            {
                ceilingFan.Medium();
            }
            else if (previousSpeed == ceilingFan.LOW) {
                ceilingFan.Low();
            }
            else if (previousSpeed == ceilingFan.OFF) {
                ceilingFan.Off();
            }
        }
    }
}
