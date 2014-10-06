namespace Command
{
    public class TurnLightsOff : ICommand
    {
        private readonly Lights _lights;

        public TurnLightsOff(Lights lights)
        {
            _lights = lights;
        }

        public void Execute()
        {
            _lights.TurnOff();
        }
    }
}