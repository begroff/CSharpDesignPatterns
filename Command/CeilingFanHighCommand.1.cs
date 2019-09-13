using System;

namespace Command
{
    public class CeilingFanHighCommand : ICommand
    {
        private CeilingFan ceilingFan;
        private int previousSpeed;

        public CeilingFanHighCommand(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }

        public void Execute()
        {
            previousSpeed = ceilingFan.GetSpeed();
            ceilingFan.High();
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
