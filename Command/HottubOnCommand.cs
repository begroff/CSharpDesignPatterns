namespace Command
{
    internal class HottubOnCommand : ICommand
    {
        private Hottub hottub;
        public HottubOnCommand(Hottub hottub)
        {
            this.hottub = hottub;
        }

        public void Execute()
        {
            throw new System.NotImplementedException();
        }

        public void Undo()
        {
            throw new System.NotImplementedException();
        }
    }
}