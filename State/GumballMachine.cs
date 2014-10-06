namespace State
{
    public class GumballMachine
    {
        public IState NoQuarterState;
        public IState HasQuarterState;
        public IState SoldState;

        public IState CurrentState;

        public GumballMachine()
        {
            NoQuarterState = new NoQuarterState(this);
            HasQuarterState = new HasQuarterState(this);
            SoldState = new SoldState(this);

            CurrentState = NoQuarterState;
        }

        public void InsertQuarter()
        {
            CurrentState.InsertQuarter();
        }

        public void EjectQuarter()
        {
            CurrentState.EjectQuarter();
        }

        public void TurnCrank()
        {
            CurrentState.TurnCrank();
        }

        public void Dispense()
        {
            CurrentState.Dispense();
        }
    }
}