namespace Command
{
    public class RemoteControl
    {
        private readonly ICommand[] _commands = new ICommand[5];

        public void SetButton(int slot, ICommand command)
        {
            _commands[slot] = command;
        }

        public void PressButton(int slot)
        {
            _commands[slot].Execute();
        }
    }
}