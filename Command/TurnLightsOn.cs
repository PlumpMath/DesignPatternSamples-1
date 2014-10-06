namespace Command
{
    public class TurnLightsOn : ICommand
    {
        private readonly Lights _lights;

        public TurnLightsOn(Lights lights)
        {
            _lights = lights;
        }

        public void Execute()
        {
            _lights.TurnOn();
        }
    }
}